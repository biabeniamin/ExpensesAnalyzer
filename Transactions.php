<?php
header('Access-Control-Allow-Origin: *'); 
header('Access-Control-Allow-Headers: *'); 
header('Access-Control-Allow-Methods: GET, POST, PUT, DELETE, OPTIONS');
$_POST = json_decode(file_get_contents('php://input'), true);
require_once 'Models/Transaction.php';
require_once 'DatabaseOperations.php';
require_once 'Helpers.php';
require_once 'Merchants.php';
require_once 'Accounts.php';
function ConvertListToTransactions($data)
{
	$transactions = [];
	
	foreach($data as $row)
	{
		$transaction = new Transaction(
		$row["AccountId"], 
		$row["MerchantId"], 
		$row["Value"] 
		);
	
		$transaction->SetTransactionId($row["TransactionId"]);
		$transaction->SetCreationTime($row["CreationTime"]);
	
		$transactions[count($transactions)] = $transaction;
	}
	
	return $transactions;
}

function GetTransactions($database)
{
	$data = $database->ReadData("SELECT * FROM Transactions");
	$transactions = ConvertListToTransactions($data);
	$transactions = CompleteMerchants($database, $transactions);
	$transactions = CompleteAccounts($database, $transactions);
	return $transactions;
}

function GetTransactionsByTransactionId($database, $transactionId)
{
	$data = $database->ReadData("SELECT * FROM Transactions WHERE TransactionId = $transactionId");
	$transactions = ConvertListToTransactions($data);
	if(0== count($transactions))
	{
		return [GetEmptyTransaction()];
	}
	CompleteMerchants($database, $transactions);
	CompleteAccounts($database, $transactions);
	return $transactions;
}

function CompleteTransactions($database, $transactions)
{
	$transactionsList = GetTransactions($database);
	foreach($transactions as $transaction)
	{
		$start = 0;
		$end = count($transactionsList) - 1;
		do
		{
	
			$mid = floor(($start + $end) / 2);
			if($transaction->GetTransactionId() > $transactionsList[$mid]->GetTransactionId())
			{
				$start = $mid + 1;
			}
			else if($transaction->GetTransactionId() < $transactionsList[$mid]->GetTransactionId())
			{
				$end = $mid - 1;
			}
			else if($transaction->GetTransactionId() == $transactionsList[$mid]->GetTransactionId())
			{
				$start = $mid + 1;
				$end = $mid - 1;
				$transaction->SetTransaction($transactionsList[$mid]);
			}
	
		}while($start <= $end);
	}
	
	return $transactions;
}

function AddTransaction($database, $transaction)
{
	$query = "INSERT INTO Transactions(AccountId, MerchantId, Value, CreationTime) VALUES(";
	$query = $query . mysqli_real_escape_string($database->connection ,$transaction->GetAccountId()).", ";
	$query = $query . mysqli_real_escape_string($database->connection ,$transaction->GetMerchantId()).", ";
	$query = $query . "'" . mysqli_real_escape_string($database->connection ,$transaction->GetValue()) . "', ";
	$query = $query . "'" . mysqli_real_escape_string($database->connection ,$transaction->GetCreationTime()) . "'";
	
	$query = $query . ");";
	$database->ExecuteSqlWithoutWarning($query);
	$id = $database->GetLastInsertedId();
	$transaction->SetTransactionId($id);
	$transaction->SetCreationTime(date('Y-m-d H:i:s'));
	$transaction->SetMerchant(GetMerchantsByMerchantId($database, $transaction->GetMerchantId())[0]);
	$transaction->SetAccount(GetAccountsByAccountId($database, $transaction->GetAccountId())[0]);

	return $transaction;
	
}

function DeleteTransaction($database, $transactionId)
{
	$transaction = GetTransactionsByTransactionId($database, $transactionId)[0];
	
	$query = "DELETE FROM Transactions WHERE TransactionId=$transactionId";
	
	$result = $database->ExecuteSqlWithoutWarning($query);
	
	if(0 != $result)
	{
		$transaction->SetTransactionId(0);
	}
	
	return $transaction;
	
}

function UpdateTransaction($database, $transaction)
{
	$query = "UPDATE Transactions SET ";
	$query = $query . "AccountId=" . $transaction->GetAccountId().", ";
	$query = $query . "MerchantId=" . $transaction->GetMerchantId().", ";
	$query = $query . "Value='" . $transaction->GetValue() . "'";
	$query = $query . " WHERE TransactionId=" . $transaction->GetTransactionId();
	
	$result = $database->ExecuteSqlWithoutWarning($query);
	if(0 == $result)
	{
		$transaction->SetTransactionId(0);
	}
	return $transaction;
	
}

function TestAddTransaction($database)
{
	$transaction = new Transaction(
		0,//AccountId
		0,//MerchantId
		0//Value
	);
	
	AddTransaction($database, $transaction);
}

function GetEmptyTransaction()
{
	$transaction = new Transaction(
		0,//AccountId
		0,//MerchantId
		0//Value
	);
	
	return $transaction;
}

if(CheckGetParameters(["cmd"]))
{
	if("getTransactions" == $_GET["cmd"])
	{
		$database = new DatabaseOperations();
			echo json_encode(GetTransactions($database));
	}

	if("getLastTransaction" == $_GET["cmd"])
	{
		$database = new DatabaseOperations();
			echo json_encode(GetLastTransaction($database));
	}

	else if("getTransactionsByTransactionId" == $_GET["cmd"])
	{
		if(CheckGetParameters([
			'transactionId'
			]))
		{
			$database = new DatabaseOperations();
			echo json_encode(GetTransactionsByTransactionId($database, 
				$_GET["transactionId"]
			));
		}
	
	}

	else if("addTransaction" == $_GET["cmd"])
	{
		if(CheckGetParameters([
			'accountId',
			'merchantId',
			'value'
		]))
		{
			$database = new DatabaseOperations();
			$transaction = new Transaction(
				$_GET['accountId'],
				$_GET['merchantId'],
				$_GET['value']
			);
		
			echo json_encode(AddTransaction($database, $transaction));
		}
	
	}

}

if(CheckGetParameters(["cmd"]))
{
	if("addTransaction" == $_GET["cmd"])
	{
		if(CheckPostParameters([
			'accountId',
			'merchantId',
			'value',
			'creationTime'
		]))
		{
			$database = new DatabaseOperations();
			
			$transaction = new Transaction(
				$_POST['accountId'],
				$_POST['merchantId'],
				$_POST['value']
			);

			$transaction->SetCreationTime($_POST['creationTime']);
			echo json_encode(AddTransaction($database, $transaction));
		}

	}
}

if(CheckGetParameters(["cmd"]))
{
	if("updateTransaction" == $_GET["cmd"])
	{
		$database = new DatabaseOperations();
		$transaction = new Transaction(
			$_POST['accountId'],
			$_POST['merchantId'],
			$_POST['value']
		);
		$transaction->SetTransactionId($_POST['transactionId']);
		$transaction->SetCreationTime($_POST['creationTime']);
		
		$transaction = UpdateTransaction($database, $transaction);
		echo json_encode($transaction);

	}
}

if("DELETE" == $_SERVER['REQUEST_METHOD']
	&& CheckGetParameters(["cmd"]))
{
	if("deleteTransaction" == $_GET["cmd"])
	{
		$database = new DatabaseOperations();
		$transactionId = $_GET['transactionId'];
		
		$transaction = DeleteTransaction($database, $transactionId);
		echo json_encode($transaction);

	}
}


function GetLastTransaction($database)
{
	$data = $database->ReadData("SELECT * FROM Transactions ORDER BY CreationTime DESC LIMIT 1");
	$transactions = ConvertListToTransactions($data);
	$transactions = CompleteMerchants($database, $transactions);
	$transactions = CompleteAccounts($database, $transactions);
	return $transactions;
}

?>
