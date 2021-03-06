<?php
header('Access-Control-Allow-Origin: *'); 
header('Access-Control-Allow-Headers: *'); 
header('Access-Control-Allow-Methods: GET, POST, PUT, DELETE, OPTIONS');
$_POST = json_decode(file_get_contents('php://input'), true);
require_once 'Models/Merchant.php';
require_once 'DatabaseOperations.php';
require_once 'Helpers.php';
require_once 'Categories.php';
function ConvertListToMerchants($data)
{
	$merchants = [];
	
	foreach($data as $row)
	{
		$merchant = new Merchant(
		$row["CategoryId"], 
		$row["Name"] 
		);
	
		$merchant->SetMerchantId($row["MerchantId"]);
		$merchant->SetCreationTime($row["CreationTime"]);
	
		$merchants[count($merchants)] = $merchant;
	}
	
	return $merchants;
}

function GetMerchants($database)
{
	$data = $database->ReadData("SELECT * FROM Merchants");
	$merchants = ConvertListToMerchants($data);
	$merchants = CompleteCategories($database, $merchants);
	return $merchants;
}

function GetMerchantsByMerchantId($database, $merchantId)
{
	$data = $database->ReadData("SELECT * FROM Merchants WHERE MerchantId = $merchantId");
	$merchants = ConvertListToMerchants($data);
	if(0== count($merchants))
	{
		return [GetEmptyMerchant()];
	}
	CompleteCategories($database, $merchants);
	return $merchants;
}

function CompleteMerchants($database, $merchants)
{
	$merchantsList = GetMerchants($database);
	foreach($merchants as $merchant)
	{
		$start = 0;
		$end = count($merchantsList) - 1;
		do
		{
	
			$mid = floor(($start + $end) / 2);
			if($merchant->GetMerchantId() > $merchantsList[$mid]->GetMerchantId())
			{
				$start = $mid + 1;
			}
			else if($merchant->GetMerchantId() < $merchantsList[$mid]->GetMerchantId())
			{
				$end = $mid - 1;
			}
			else if($merchant->GetMerchantId() == $merchantsList[$mid]->GetMerchantId())
			{
				$start = $mid + 1;
				$end = $mid - 1;
				$merchant->SetMerchant($merchantsList[$mid]);
			}
	
		}while($start <= $end);
	}
	
	return $merchants;
}

function AddMerchant($database, $merchant)
{
	$query = "INSERT INTO Merchants(CategoryId, Name, CreationTime) VALUES(";
	$query = $query . mysqli_real_escape_string($database->connection ,$merchant->GetCategoryId()).", ";
	$query = $query . "'" . mysqli_real_escape_string($database->connection ,$merchant->GetName()) . "', ";
	$query = $query . "NOW()"."";
	
	$query = $query . ");";
	$database->ExecuteSqlWithoutWarning($query);
	$id = $database->GetLastInsertedId();
	$merchant->SetMerchantId($id);
	$merchant->SetCreationTime(date('Y-m-d H:i:s'));
	$merchant->SetCategory(GetCategoriesByCategoryId($database, $merchant->GetCategoryId())[0]);
	return $merchant;
	
}

function DeleteMerchant($database, $merchantId)
{
	$merchant = GetMerchantsByMerchantId($database, $merchantId)[0];
	
	$query = "DELETE FROM Merchants WHERE MerchantId=$merchantId";
	
	$result = $database->ExecuteSqlWithoutWarning($query);
	
	if(0 != $result)
	{
		$merchant->SetMerchantId(0);
	}
	
	return $merchant;
	
}

function UpdateMerchant($database, $merchant)
{
	$query = "UPDATE Merchants SET ";
	$query = $query . "CategoryId=" . $merchant->GetCategoryId().", ";
	$query = $query . "Name='" . $merchant->GetName() . "'";
	$query = $query . " WHERE MerchantId=" . $merchant->GetMerchantId();
	
	$result = $database->ExecuteSqlWithoutWarning($query);
	if(0 == $result)
	{
		$merchant->SetMerchantId(0);
	}
	return $merchant;
	
}

function TestAddMerchant($database)
{
	$merchant = new Merchant(
		0,//CategoryId
		'Test'//Name
	);
	
	AddMerchant($database, $merchant);
}

function GetEmptyMerchant()
{
	$merchant = new Merchant(
		0,//CategoryId
		''//Name
	);
	
	return $merchant;
}

function GetMerchantAmount($database, $month)
{
	if($month != 0)
		$data = $database->ReadData("SELECT MerchantId,name,creationTime,IFNULL((select sum(value) from transactions where merchants.MerchantId=transactions.MerchantId and MONTH(transactions.creationTime)=$month), 0) as value FROM merchants");
	else
		$data = $database->ReadData("SELECT MerchantId,name,creationTime,IFNULL((select sum(value) from transactions where merchants.MerchantId=transactions.MerchantId), 0) as value FROM merchants");
	//$categories = ConvertListToCategories($data);
	
//var_dump(json_encode($categories));
	return json_encode($data);
}

if(CheckGetParameters(["cmd"]))
{
	if("getMerchants" == $_GET["cmd"])
	{
		$database = new DatabaseOperations();
			echo json_encode(GetMerchants($database));
	}

	if("getLastMerchant" == $_GET["cmd"])
	{
		$database = new DatabaseOperations();
			echo json_encode(GetLastMerchant($database));
	}
	else if("getMerchantsByValue" == $_GET["cmd"]  && CheckGetParameters(["month"]))
	{
		$database = new DatabaseOperations();
			echo GetMerchantAmount($database, $_GET['month']);
	}

	else if("getMerchantsByValue" == $_GET["cmd"])
	{
		$database = new DatabaseOperations();
			echo GetMerchantAmount($database, 8);
	}

	else if("getMerchantsByMerchantId" == $_GET["cmd"])
	{
		if(CheckGetParameters([
			'merchantId'
			]))
		{
			$database = new DatabaseOperations();
			echo json_encode(GetMerchantsByMerchantId($database, 
				$_GET["merchantId"]
			));
		}
	
	}

	else if("addMerchant" == $_GET["cmd"])
	{
		if(CheckGetParameters([
			'categoryId',
			'name'
		]))
		{
			$database = new DatabaseOperations();
			$merchant = new Merchant(
				$_GET['categoryId'],
				$_GET['name']
			);
		
			echo json_encode(AddMerchant($database, $merchant));
		}
	
	}

}

if(CheckGetParameters(["cmd"]))
{
	if("addMerchant" == $_GET["cmd"])
	{
		if(CheckPostParameters([
			'categoryId',
			'name'
		]))
		{
			$database = new DatabaseOperations();
			$merchant = new Merchant(
				$_POST['categoryId'],
				$_POST['name']
			);
	
			echo json_encode(AddMerchant($database, $merchant));
		}

	}
}

if(CheckGetParameters(["cmd"]))
{
	if("updateMerchant" == $_GET["cmd"])
	{
		$database = new DatabaseOperations();
		$merchant = new Merchant(
			$_POST['categoryId'],
			$_POST['name']
		);
		$merchant->SetMerchantId($_POST['merchantId']);
		$merchant->SetCreationTime($_POST['creationTime']);
		
		$merchant = UpdateMerchant($database, $merchant);
		echo json_encode($merchant);

	}
}

if("DELETE" == $_SERVER['REQUEST_METHOD']
	&& CheckGetParameters(["cmd"]))
{
	if("deleteMerchant" == $_GET["cmd"])
	{
		$database = new DatabaseOperations();
		$merchantId = $_GET['merchantId'];
		
		$merchant = DeleteMerchant($database, $merchantId);
		echo json_encode($merchant);

	}
}


function GetLastMerchant($database)
{
	$data = $database->ReadData("SELECT * FROM Merchants ORDER BY CreationTime DESC LIMIT 1");
	$merchants = ConvertListToMerchants($data);
	$merchants = CompleteCategories($database, $merchants);
	return $merchants;
}

?>
