<?php
//generated automatically
require_once 'Category.php';
require_once 'Account.php';
class Transaction
{
	var $transactionId;
	var $accountId;
	var $categoryId;
	var $name;
	var $value;
	var $creationTime;
	var $categorie;
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
	
	function GetCategoryId()
	{
		return $this->categoryId;
	}
	function SetCategoryId($value)
	{
		$this->categoryId = $value;
	}
	
	function GetName()
	{
		return $this->name;
	}
	function SetName($value)
	{
		$this->name = $value;
	}
	
	function GetValue()
	{
		return $this->value;
	}
	function SetValue($value)
	{
		$this->value = $value;
	}
	
	function GetCreationTime()
	{
		return $this->creationTime;
	}
	function SetCreationTime($value)
	{
		$this->creationTime = $value;
	}
	
	function GetCategory()
	{
		return $this->categorie;
	}
	function SetCategory($value)
	{
		$this->categorie = $value;
	}
	
	function GetAccount()
	{
		return $this->account;
	}
	function SetAccount($value)
	{
		$this->account = $value;
	}
	

	function Transaction($AccountId, $CategoryId, $Name, $Value)
	{
		$this->transactionId = 0;
	
		$this->accountId = $AccountId;
		$this->categoryId = $CategoryId;
		$this->name = $Name;
		$this->value = $Value;
	}

}
?>
