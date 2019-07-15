<?php
header('Access-Control-Allow-Origin: *'); 
header('Access-Control-Allow-Headers: *'); 
header('Access-Control-Allow-Methods: GET, POST, PUT, DELETE, OPTIONS');
$_POST = json_decode(file_get_contents('php://input'), true);
require_once 'Models/Category.php';
require_once 'DatabaseOperations.php';
require_once 'Helpers.php';
function ConvertListToCategories($data)
{
	$categories = [];
	
	foreach($data as $row)
	{
		$categorie = new Category(
		$row["Name"] 
		);
	
		$categorie->SetCategoryId($row["CategoryId"]);
		$categorie->SetCreationTime($row["CreationTime"]);
	
		$categories[count($categories)] = $categorie;
	}
	
	return $categories;
}

function GetCategories($database)
{
	$data = $database->ReadData("SELECT * FROM Categories");
	$categories = ConvertListToCategories($data);
	return $categories;
}

function GetCategoriesByCategoryId($database, $categoryId)
{
	$data = $database->ReadData("SELECT * FROM Categories WHERE CategoryId = $categoryId");
	$categories = ConvertListToCategories($data);
	if(0== count($categories))
	{
		return [GetEmptyCategory()];
	}
	return $categories;
}

function CompleteCategories($database, $categories)
{
	$categoriesList = GetCategories($database);
	foreach($categories as $categorie)
	{
		$start = 0;
		$end = count($categoriesList) - 1;
		do
		{
	
			$mid = floor(($start + $end) / 2);
			if($categorie->GetCategoryId() > $categoriesList[$mid]->GetCategoryId())
			{
				$start = $mid + 1;
			}
			else if($categorie->GetCategoryId() < $categoriesList[$mid]->GetCategoryId())
			{
				$end = $mid - 1;
			}
			else if($categorie->GetCategoryId() == $categoriesList[$mid]->GetCategoryId())
			{
				$start = $mid + 1;
				$end = $mid - 1;
				$categorie->SetCategory($categoriesList[$mid]);
			}
	
		}while($start <= $end);
	}
	
	return $categories;
}

function AddCategory($database, $categorie)
{
	$query = "INSERT INTO Categories(Name, CreationTime) VALUES(";
	$query = $query . "'" . mysqli_real_escape_string($database->connection ,$categorie->GetName()) . "', ";
	$query = $query . "NOW()"."";
	
	$query = $query . ");";
	$database->ExecuteSqlWithoutWarning($query);
	$id = $database->GetLastInsertedId();
	$categorie->SetCategoryId($id);
	$categorie->SetCreationTime(date('Y-m-d H:i:s'));
	return $categorie;
	
}

function DeleteCategory($database, $categoryId)
{
	$categorie = GetCategoriesByCategoryId($database, $categoryId)[0];
	
	$query = "DELETE FROM Categories WHERE CategoryId=$categoryId";
	
	$result = $database->ExecuteSqlWithoutWarning($query);
	
	if(0 != $result)
	{
		$categorie->SetCategoryId(0);
	}
	
	return $categorie;
	
}

function UpdateCategory($database, $categorie)
{
	$query = "UPDATE Categories SET ";
	$query = $query . "Name='" . $categorie->GetName() . "'";
	$query = $query . " WHERE CategoryId=" . $categorie->GetCategoryId();
	
	$result = $database->ExecuteSqlWithoutWarning($query);
	if(0 == $result)
	{
		$categorie->SetCategoryId(0);
	}
	return $categorie;
	
}

function TestAddCategory($database)
{
	$categorie = new Category(
		'Test'//Name
	);
	
	AddCategory($database, $categorie);
}

function GetEmptyCategory()
{
	$categorie = new Category(
		''//Name
	);
	
	return $categorie;
}

if(CheckGetParameters(["cmd"]))
{
	if("getCategories" == $_GET["cmd"])
	{
		$database = new DatabaseOperations();
			echo json_encode(GetCategories($database));
	}

	if("getLastCategory" == $_GET["cmd"])
	{
		$database = new DatabaseOperations();
			echo json_encode(GetLastCategory($database));
	}

	else if("getCategoriesByCategoryId" == $_GET["cmd"])
	{
		if(CheckGetParameters([
			'categoryId'
			]))
		{
			$database = new DatabaseOperations();
			echo json_encode(GetCategoriesByCategoryId($database, 
				$_GET["categoryId"]
			));
		}
	
	}

	else if("addCategory" == $_GET["cmd"])
	{
		if(CheckGetParameters([
			'name'
		]))
		{
			$database = new DatabaseOperations();
			$categorie = new Category(
				$_GET['name']
			);
		
			echo json_encode(AddCategory($database, $categorie));
		}
	
	}

}

if(CheckGetParameters(["cmd"]))
{
	if("addCategory" == $_GET["cmd"])
	{
		if(CheckPostParameters([
			'name'
		]))
		{
			$database = new DatabaseOperations();
			$categorie = new Category(
				$_POST['name']
			);
	
			echo json_encode(AddCategory($database, $categorie));
		}

	}
}

if(CheckGetParameters(["cmd"]))
{
	if("updateCategory" == $_GET["cmd"])
	{
		$database = new DatabaseOperations();
		$categorie = new Category(
			$_POST['name']
		);
		$categorie->SetCategoryId($_POST['categoryId']);
		$categorie->SetCreationTime($_POST['creationTime']);
		
		$categorie = UpdateCategory($database, $categorie);
		echo json_encode($categorie);

	}
}

if("DELETE" == $_SERVER['REQUEST_METHOD']
	&& CheckGetParameters(["cmd"]))
{
	if("deleteCategory" == $_GET["cmd"])
	{
		$database = new DatabaseOperations();
		$categoryId = $_GET['categoryId'];
		
		$categorie = DeleteCategory($database, $categoryId);
		echo json_encode($categorie);

	}
}


function GetLastCategory($database)
{
	$data = $database->ReadData("SELECT * FROM Categories ORDER BY CreationTime DESC LIMIT 1");
	$categories = ConvertListToCategories($data);
	return $categories;
}

?>
