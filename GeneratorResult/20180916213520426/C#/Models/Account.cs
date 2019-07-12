//generated automatically
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
namespace DatabaseFunctionsGenerator
{
	public class Account
	{
		private int _accountId;
		private string _email;
		private string _password;
		private double _balance;
		private DateTime _creationTime;
		
		[JsonProperty(PropertyName = "accountId")]
		public int AccountId
		{
			get
			{
				return _accountId;
			}
			set
			{
				_accountId = value;
			}
		}
		
		[JsonProperty(PropertyName = "email")]
		public string Email
		{
			get
			{
				return _email;
			}
			set
			{
				_email = value;
			}
		}
		
		[JsonProperty(PropertyName = "password")]
		public string Password
		{
			get
			{
				return _password;
			}
			set
			{
				_password = value;
			}
		}
		
		[JsonProperty(PropertyName = "balance")]
		public double Balance
		{
			get
			{
				return _balance;
			}
			set
			{
				_balance = value;
			}
		}
		
		[JsonProperty(PropertyName = "creationTime")]
		public DateTime CreationTime
		{
			get
			{
				return _creationTime;
			}
			set
			{
				_creationTime = value;
			}
		}
		
		
		public Account(int accountId, string email, string password, double balance, DateTime creationTime)
		{
			_accountId = accountId;
			_email = email;
			_password = password;
			_balance = balance;
			_creationTime = creationTime;
		}
		
		public Account(string email, string password, double balance)
		{
			_email = email;
			_password = password;
			_balance = balance;
		}
		
		public Account()
			 :this(
				"Test", //Email
				"Test", //Password
				0 //Balance
			)
		{
			_accountId = 0;
			_creationTime = new DateTime(1970, 1, 1, 0, 0, 0);
		}
		
	
	}

}
