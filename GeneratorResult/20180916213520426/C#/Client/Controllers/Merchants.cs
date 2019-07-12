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
	public static class Merchants
	{
		public static async Task<List<Merchant>> GetMerchants()
		{
			List<Merchant> merchants;
			string data;
			
			merchants = new List<Merchant>();
			data = "";
			
			try
			{
				data = await HttpRequestClient.GetRequest("Merchants.php?cmd=getMerchants");
				merchants = JsonConvert.DeserializeObject<List<Merchant>>(data);
			}
			catch(Exception ee)
			{
				Console.WriteLine(ee.Message);
			}
			
			return merchants;
		
		}
		
		public static async Task<Merchant> AddMerchant(Merchant merchant)
		{
			string data;
			
			data = "";
			
			try
			{
				data = await HttpRequestClient.PostRequest("Merchants.php?cmd=addMerchant", merchant);
				merchant = JsonConvert.DeserializeObject<Merchant>(data);
			}
			catch(Exception ee)
			{
				Console.WriteLine(ee.Message);
			}
			
			return merchant;
		
		}
		
	
	}

}
