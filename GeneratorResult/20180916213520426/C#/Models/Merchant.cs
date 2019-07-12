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
	public class Merchant
	{
		private int _merchantId;
		private string _name;
		private DateTime _creationTime;
		
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
		
		
		public Merchant(int merchantId, string name, DateTime creationTime)
		{
			_merchantId = merchantId;
			_name = name;
			_creationTime = creationTime;
		}
		
		public Merchant(string name)
		{
			_name = name;
		}
		
		public Merchant()
			 :this(
				"Test" //Name
			)
		{
			_merchantId = 0;
			_creationTime = new DateTime(1970, 1, 1, 0, 0, 0);
		}
		
	
	}

}
