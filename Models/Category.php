<?php
//generated automatically
class Category
{
	var $categoryId;
	var $name;
	var $creationTime;

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
	

	function Category($Name)
	{
		$this->categoryId = 0;
	
		$this->name = $Name;
	}

}
?>
