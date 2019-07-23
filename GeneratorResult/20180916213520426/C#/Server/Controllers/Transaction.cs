//generated automatically
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Server.Controllers;
namespace DatabaseFunctionsGenerator
{
	public class TransactionController : ApiController
	{
		// GET transactions/values
		public IEnumerable<Transaction> Get()
		{
			MySqlDataReader reader = new DatabaseOperations().GetReader("SELECT * FROM Transactions");
			List<Transaction> list = new List<Transaction>();
			
			while(reader.Read())
			{
				list.Add(new Transaction(
					(int)reader["TransactionId"],
					(int)reader["AccountId"],
					(int)reader["MerchantId"],
					(double)reader["Value"],
					(DateTime)reader["CreationTime"]
				));
			}
			
			return list;
		}
		
		// POST transactions/values
		public void Post([FromBody]Transaction data)
		{
			DatabaseOperations db = new DatabaseOperations();
			MySqlCommand command = new MySqlCommand("INSERT INTO Transactions(AccountId,  MerchantId,  Value,  CreationTime) VALUES(@AccountId,  @MerchantId,  @Value,  @CreationTime)");
			
			command.Parameters.AddWithValue("@AccountId", data.AccountId);
			command.Parameters.AddWithValue("@MerchantId", data.MerchantId);
			command.Parameters.AddWithValue("@Value", data.Value);
			command.Parameters.AddWithValue("@CreationTime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
			
			db.ExecuteQuery(command);
		}
		
		// DELETE transactions/values/id
		public void Delete(int id)
		{
			DatabaseOperations db = new DatabaseOperations();
			MySqlCommand command = new MySqlCommand("DELETE FROM Transactions WHERE TransactionId=@Id");
			
			command.Parameters.AddWithValue("@Id", id);
			
			db.ExecuteQuery(command);
		}
		
	
	}

}
