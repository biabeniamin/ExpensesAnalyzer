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
	public class AccountController : ApiController
	{
		// GET accounts/values
		public IEnumerable<Account> Get()
		{
			MySqlDataReader reader = new DatabaseOperations().GetReader("SELECT * FROM Accounts");
			List<Account> list = new List<Account>();
			
			while(reader.Read())
			{
				list.Add(new Account(
					(int)reader["AccountId"],
					(string)reader["Email"],
					(string)reader["Password"],
					(double)reader["Balance"],
					(DateTime)reader["CreationTime"]
				));
			}
			
			return list;
		}
		
		// POST accounts/values
		public void Post([FromBody]Account data)
		{
			DatabaseOperations db = new DatabaseOperations();
			MySqlCommand command = new MySqlCommand("INSERT INTO Accounts(Email,  Password,  Balance,  CreationTime) VALUES(@Email,  @Password,  @Balance,  @CreationTime)");
			
			command.Parameters.AddWithValue("@Email", data.Email);
			command.Parameters.AddWithValue("@Password", data.Password);
			command.Parameters.AddWithValue("@Balance", data.Balance);
			command.Parameters.AddWithValue("@CreationTime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
			
			db.ExecuteQuery(command);
		}
		
		// DELETE accounts/values/id
		public void Delete(int id)
		{
			DatabaseOperations db = new DatabaseOperations();
			MySqlCommand command = new MySqlCommand("DELETE FROM Accounts WHERE AccountId=@Id");
			
			command.Parameters.AddWithValue("@Id", id);
			
			db.ExecuteQuery(command);
		}
		
	
	}

}
