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
		private int _merchantId;
		private double _value;
		private DateTime _creationTime;
		private Merchant _merchant;
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
		
		[JsonProperty(PropertyName = "merchantId")]
		public int MerchantId
		{
			get
			{
				return _merchantId;
			}
			set
			{
				_merchantId = value;
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
		
		[JsonProperty(PropertyName = "merchant")]
		public Merchant Merchant
		{
			get
			{
				return _merchant;
			}
			set
			{
				_merchant = value;
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
		
		
		public Transaction(int transactionId, int accountId, int merchantId, double value, DateTime creationTime)
		{
			_transactionId = transactionId;
			_accountId = accountId;
			_merchantId = merchantId;
			_value = value;
			_creationTime = creationTime;
		}
		
		public Transaction(int accountId, int merchantId, double value)
		{
			_accountId = accountId;
			_merchantId = merchantId;
			_value = value;
		}
		
		public Transaction(int accountId, int merchantId, double value, Merchant merchant, Account account)
			:this(accountId, merchantId, value)
		{
			_accountId = accountId;
			_merchantId = merchantId;
			_value = value;
		}
		
		public Transaction()
			 :this(
				0, //AccountId
				0, //MerchantId
				0 //Value
			)
		{
			_transactionId = 0;
			_creationTime = new DateTime(1970, 1, 1, 0, 0, 0);
		}
		
	
	}

}
