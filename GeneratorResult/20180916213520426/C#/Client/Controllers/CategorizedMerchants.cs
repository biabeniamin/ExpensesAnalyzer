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
	public static class CategorizedMerchants
	{
		public static async Task<List<CategorizedMerchant>> GetCategorizedMerchants()
		{
			List<CategorizedMerchant> categorizedMerchants;
			string data;
			
			categorizedMerchants = new List<CategorizedMerchant>();
			data = "";
			
			try
			{
				data = await HttpRequestClient.GetRequest("CategorizedMerchants.php?cmd=getCategorizedMerchants");
				categorizedMerchants = JsonConvert.DeserializeObject<List<CategorizedMerchant>>(data);
			}
			catch(Exception ee)
			{
				Console.WriteLine(ee.Message);
			}
			
			return categorizedMerchants;
		
		}
		
		public static async Task<CategorizedMerchant> AddCategorizedMerchant(CategorizedMerchant categorizedMerchant)
		{
			string data;
			
			data = "";
			
			try
			{
				data = await HttpRequestClient.PostRequest("CategorizedMerchants.php?cmd=addCategorizedMerchant", categorizedMerchant);
				categorizedMerchant = JsonConvert.DeserializeObject<CategorizedMerchant>(data);
			}
			catch(Exception ee)
			{
				Console.WriteLine(ee.Message);
			}
			
			return categorizedMerchant;
		
		}
		
	
	}

}
