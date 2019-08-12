<?php
//generated automatically
require_once 'Merchant.php';
require_once 'Account.php';
class Transaction
{
	var $transactionId;
	var $accountId;
	var $merchantId;
	var $value;
	var $description;
	var $creationTime;
	var $merchant;
	var $account;

	function GetTransactionId()
	{
		return $this->transactionId;
	}
	function SetTransactionId($value)
	{
		$this->transactionId = $value;
	}
	
	function GetAccountId()
	{
		return $this->accountId;
	}
	function SetAccountId($value)
	{
		$this->accountId = $value;
	}
	
	function GetMerchantId()
	{
		return $this->merchantId;
	}
	function SetMerchantId($value)
	{
		$this->merchantId = $value;
	}
	
	function GetValue()
	{
		return $this->value;
	}
	function SetValue($value)
	{
		$this->value = $value;
	}

	function GetDescription()
	{
		return $this->description;
	}
	function SetDescription($value)
	{
		$this->description = $value;
	}
	
	function GetCreationTime()
	{
		return $this->creationTime;
	}
	function SetCreationTime($value)
	{
		$this->creationTime = $value;
	}
	
	function GetMerchant()
	{
		return $this->merchant;
	}
	function SetMerchant($value)
	{
		$this->merchant = $value;
	}
	
	function GetAccount()
	{
		return $this->account;
	}
	function SetAccount($value)
	{
		$this->account = $value;
	}
	

	function Transaction($AccountId, $MerchantId, $Value, $Description)
	{
		$this->transactionId = 0;
	
		$this->accountId = $AccountId;
		$this->merchantId = $MerchantId;
		$this->value = $Value;
		$this->description = $Description;
	}

}
?>
