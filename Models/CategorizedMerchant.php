<?php
//generated automatically
require_once 'Merchant.php';
require_once 'Category.php';
class CategorizedMerchant
{
	var $categorizedMerchantId;
	var $categoryId;
	var $merchantId;
	var $creationTime;
	var $merchant;
	var $categorie;

	function GetCategorizedMerchantId()
	{
		return $this->categorizedMerchantId;
	}
	function SetCategorizedMerchantId($value)
	{
		$this->categorizedMerchantId = $value;
	}
	
	function GetCategoryId()
	{
		return $this->categoryId;
	}
	function SetCategoryId($value)
	{
		$this->categoryId = $value;
	}
	
	function GetMerchantId()
	{
		return $this->merchantId;
	}
	function SetMerchantId($value)
	{
		$this->merchantId = $value;
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
	
	function GetCategory()
	{
		return $this->categorie;
	}
	function SetCategory($value)
	{
		$this->categorie = $value;
	}
	

	function CategorizedMerchant($CategoryId, $MerchantId)
	{
		$this->categorizedMerchantId = 0;
	
		$this->categoryId = $CategoryId;
		$this->merchantId = $MerchantId;
	}

}
?>
