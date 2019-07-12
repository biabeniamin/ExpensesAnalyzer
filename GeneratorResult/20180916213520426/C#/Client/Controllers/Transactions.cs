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
	public static class Transactions
	{
		public static async Task<List<Transaction>> GetTransactions()
		{
			List<Transaction> transactions;
			string data;
			
			transactions = new List<Transaction>();
			data = "";
			
			try
			{
				data = await HttpRequestClient.GetRequest("Transactions.php?cmd=getTransactions");
				transactions = JsonConvert.DeserializeObject<List<Transaction>>(data);
			}
			catch(Exception ee)
			{
				Console.WriteLine(ee.Message);
			}
			
			return transactions;
		
		}
		
		public static async Task<Transaction> AddTransaction(Transaction transaction)
		{
			string data;
			
			data = "";
			
			try
			{
				data = await HttpRequestClient.PostRequest("Transactions.php?cmd=addTransaction", transaction);
				transaction = JsonConvert.DeserializeObject<Transaction>(data);
			}
			catch(Exception ee)
			{
				Console.WriteLine(ee.Message);
			}
			
			return transaction;
		
		}
		
	
	}

}
