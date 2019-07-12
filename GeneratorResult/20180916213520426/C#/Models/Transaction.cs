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
	public class Transaction
	{
		private int _transactionId;
		private int _accountId;
		private int _categoryId;
		private string _name;
		private double _value;
		private DateTime _creationTime;
		private Category _categorie;
		private Account _account;
		
		[JsonProperty(PropertyName = "transactionId")]
		public int TransactionId
		{
			get
			{
				return _transactionId;
			}
			set
			{
				_transactionId = value;
			}
		}
		
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
		
		[JsonProperty(PropertyName = "categoryId")]
		public int CategoryId
		{
			get
			{
				return _categoryId;
			}
			set
			{
				_categoryId = value;
			}
		}
		
		[JsonProperty(PropertyName = "name")]
		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				_name = value;
			}
		}
		
		[JsonProperty(PropertyName = "value")]
		public double Value
		{
			get
			{
				return _value;
			}
			set
			{
				_value = value;
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
		
		[JsonProperty(PropertyName = "categorie")]
		public Category Category
		{
			get
			{
				return _categorie;
			}
			set
			{
				_categorie = value;
			}
		}
		
		[JsonProperty(PropertyName = "account")]
		public Account Account
		{
			get
			{
				return _account;
			}
			set
			{
				_account = value;
			}
		}
		
		
		public Transaction(int transactionId, int accountId, int categoryId, string name, double value, DateTime creationTime)
		{
			_transactionId = transactionId;
			_accountId = accountId;
			_categoryId = categoryId;
			_name = name;
			_value = value;
			_creationTime = creationTime;
		}
		
		public Transaction(int accountId, int categoryId, string name, double value)
		{
			_accountId = accountId;
			_categoryId = categoryId;
			_name = name;
			_value = value;
		}
		
		public Transaction(int accountId, int categoryId, string name, double value, Category categorie, Account account)
			:this(accountId, categoryId, name, value)
		{
			_accountId = accountId;
			_categoryId = categoryId;
			_name = name;
			_value = value;
		}
		
		public Transaction()
			 :this(
				0, //AccountId
				0, //CategoryId
				"Test", //Name
				0 //Value
			)
		{
			_transactionId = 0;
			_creationTime = new DateTime(1970, 1, 1, 0, 0, 0);
		}
		
	
	}

}
