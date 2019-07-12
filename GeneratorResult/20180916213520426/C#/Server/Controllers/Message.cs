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
	public class MessageController : ApiController
	{
		// GET messages/values
		public IEnumerable<Message> Get()
		{
			MySqlDataReader reader = new DatabaseOperations().GetReader("SELECT * FROM Messages");
			List<Message> list = new List<Message>();
			
			while(reader.Read())
			{
				list.Add(new Message(
					(int)reader["MessageId"],
					(string)reader["Content"],
					(int)reader["Source"],
					(DateTime)reader["CreationTime"]
				));
			}
			
			return list;
		}
		
		// POST messages/values
		public void Post([FromBody]Message data)
		{
			DatabaseOperations db = new DatabaseOperations();
			MySqlCommand command = new MySqlCommand("INSERT INTO Messages(Content,  Source,  CreationTime) VALUES(@Content,  @Source,  @CreationTime)");
			
			command.Parameters.AddWithValue("@Content", data.Content);
			command.Parameters.AddWithValue("@Source", data.Source);
			command.Parameters.AddWithValue("@CreationTime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
			
			db.ExecuteQuery(command);
		}
		
		// DELETE messages/values/id
		public void Delete(int id)
		{
			DatabaseOperations db = new DatabaseOperations();
			MySqlCommand command = new MySqlCommand("DELETE FROM Messages WHERE MessageId=@Id");
			
			command.Parameters.AddWithValue("@Id", id);
			
			db.ExecuteQuery(command);
		}
		
	
	}

}
