<?php
//generated automatically
require_once 'Category.php';
class Merchant
{
	var $merchantId;
	var $categoryId;
	var $name;
	var $creationTime;
	var $categorie;

	function GetMerchantId()
	{
		return $this->merchantId;
	}
	function SetMerchantId($value)
	{
		$this->merchantId = $value;
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
	

	function Merchant($CategoryId, $Name)
	{
		$this->merchantId = 0;
	
		$this->categoryId = $CategoryId;
		$this->name = $Name;
	}

}
?>
