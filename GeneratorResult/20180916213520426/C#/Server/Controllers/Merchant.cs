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
	public class MerchantController : ApiController
	{
		// GET merchants/values
		public IEnumerable<Merchant> Get()
		{
			MySqlDataReader reader = new DatabaseOperations().GetReader("SELECT * FROM Merchants");
			List<Merchant> list = new List<Merchant>();
			
			while(reader.Read())
			{
				list.Add(new Merchant(
					(int)reader["MerchantId"],
					(int)reader["CategoryId"],
					(string)reader["Name"],
					(DateTime)reader["CreationTime"]
				));
			}
			
			return list;
		}
		
		// POST merchants/values
		public void Post([FromBody]Merchant data)
		{
			DatabaseOperations db = new DatabaseOperations();
			MySqlCommand command = new MySqlCommand("INSERT INTO Merchants(CategoryId,  Name,  CreationTime) VALUES(@CategoryId,  @Name,  @CreationTime)");
			
			command.Parameters.AddWithValue("@CategoryId", data.CategoryId);
			command.Parameters.AddWithValue("@Name", data.Name);
			command.Parameters.AddWithValue("@CreationTime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
			
			db.ExecuteQuery(command);
		}
		
		// DELETE merchants/values/id
		public void Delete(int id)
		{
			DatabaseOperations db = new DatabaseOperations();
			MySqlCommand command = new MySqlCommand("DELETE FROM Merchants WHERE MerchantId=@Id");
			
			command.Parameters.AddWithValue("@Id", id);
			
			db.ExecuteQuery(command);
		}
		
	
	}

}
