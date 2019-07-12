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
	public class CategoryController : ApiController
	{
		// GET categories/values
		public IEnumerable<Category> Get()
		{
			MySqlDataReader reader = new DatabaseOperations().GetReader("SELECT * FROM Categories");
			List<Category> list = new List<Category>();
			
			while(reader.Read())
			{
				list.Add(new Category(
					(int)reader["CategoryId"],
					(string)reader["Name"],
					(DateTime)reader["CreationTime"]
				));
			}
			
			return list;
		}
		
		// POST categories/values
		public void Post([FromBody]Category data)
		{
			DatabaseOperations db = new DatabaseOperations();
			MySqlCommand command = new MySqlCommand("INSERT INTO Categories(Name,  CreationTime) VALUES(@Name,  @CreationTime)");
			
			command.Parameters.AddWithValue("@Name", data.Name);
			command.Parameters.AddWithValue("@CreationTime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
			
			db.ExecuteQuery(command);
		}
		
		// DELETE categories/values/id
		public void Delete(int id)
		{
			DatabaseOperations db = new DatabaseOperations();
			MySqlCommand command = new MySqlCommand("DELETE FROM Categories WHERE CategoryId=@Id");
			
			command.Parameters.AddWithValue("@Id", id);
			
			db.ExecuteQuery(command);
		}
		
	
	}

}
