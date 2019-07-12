//generated automatically
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using Newtonsoft.Json;
namespace DatabaseFunctionsGenerator
{
	public static class Categories
	{
		public static async Task<List<Category>> GetCategories()
		{
			List<Category> categories;
			string data;
			
			categories = new List<Category>();
			data = "";
			
			try
			{
				data = await HttpRequestClient.GetRequest("Categories.php?cmd=getCategories");
				categories = JsonConvert.DeserializeObject<List<Category>>(data);
			}
			catch(Exception ee)
			{
				Console.WriteLine(ee.Message);
			}
			
			return categories;
		
		}
		
		public static async Task<Category> AddCategory(Category categorie)
		{
			string data;
			
			data = "";
			
			try
			{
				data = await HttpRequestClient.PostRequest("Categories.php?cmd=addCategory", categorie);
				categorie = JsonConvert.DeserializeObject<Category>(data);
			}
			catch(Exception ee)
			{
				Console.WriteLine(ee.Message);
			}
			
			return categorie;
		
		}
		
	
	}

}
