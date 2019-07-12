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
	public class CategorizedMerchantController : ApiController
	{
		// GET categorizedMerchants/values
		public IEnumerable<CategorizedMerchant> Get()
		{
			MySqlDataReader reader = new DatabaseOperations().GetReader("SELECT * FROM CategorizedMerchants");
			List<CategorizedMerchant> list = new List<CategorizedMerchant>();
			
			while(reader.Read())
			{
				list.Add(new CategorizedMerchant(
					(int)reader["CategorizedMerchantId"],
					(int)reader["CategoryId"],
					(int)reader["MerchantId"],
					(DateTime)reader["CreationTime"]
				));
			}
			
			return list;
		}
		
		// POST categorizedMerchants/values
		public void Post([FromBody]CategorizedMerchant data)
		{
			DatabaseOperations db = new DatabaseOperations();
			MySqlCommand command = new MySqlCommand("INSERT INTO CategorizedMerchants(CategoryId,  MerchantId,  CreationTime) VALUES(@CategoryId,  @MerchantId,  @CreationTime)");
			
			command.Parameters.AddWithValue("@CategoryId", data.CategoryId);
			command.Parameters.AddWithValue("@MerchantId", data.MerchantId);
			command.Parameters.AddWithValue("@CreationTime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
			
			db.ExecuteQuery(command);
		}
		
		// DELETE categorizedMerchants/values/id
		public void Delete(int id)
		{
			DatabaseOperations db = new DatabaseOperations();
			MySqlCommand command = new MySqlCommand("DELETE FROM CategorizedMerchants WHERE CategorizedMerchantId=@Id");
			
			command.Parameters.AddWithValue("@Id", id);
			
			db.ExecuteQuery(command);
		}
		
	
	}

}
