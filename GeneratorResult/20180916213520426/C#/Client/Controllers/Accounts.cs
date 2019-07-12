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
	public static class Accounts
	{
		public static async Task<List<Account>> GetAccounts()
		{
			List<Account> accounts;
			string data;
			
			accounts = new List<Account>();
			data = "";
			
			try
			{
				data = await HttpRequestClient.GetRequest("Accounts.php?cmd=getAccounts");
				accounts = JsonConvert.DeserializeObject<List<Account>>(data);
			}
			catch(Exception ee)
			{
				Console.WriteLine(ee.Message);
			}
			
			return accounts;
		
		}
		
		public static async Task<Account> AddAccount(Account account)
		{
			string data;
			
			data = "";
			
			try
			{
				data = await HttpRequestClient.PostRequest("Accounts.php?cmd=addAccount", account);
				account = JsonConvert.DeserializeObject<Account>(data);
			}
			catch(Exception ee)
			{
				Console.WriteLine(ee.Message);
			}
			
			return account;
		
		}
		
	
	}

}
