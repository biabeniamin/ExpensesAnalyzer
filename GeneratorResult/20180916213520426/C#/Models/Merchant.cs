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
		private int _categoryId;
		private string _name;
		private DateTime _creationTime;
		private Category _categorie;
		
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
		
		
		public Merchant(int merchantId, int categoryId, string name, DateTime creationTime)
		{
			_merchantId = merchantId;
			_categoryId = categoryId;
			_name = name;
			_creationTime = creationTime;
		}
		
		public Merchant(int categoryId, string name)
		{
			_categoryId = categoryId;
			_name = name;
		}
		
		public Merchant(int categoryId, string name, Category categorie)
			:this(categoryId, name)
		{
			_categoryId = categoryId;
			_name = name;
		}
		
		public Merchant()
			 :this(
				0, //CategoryId
				"Test" //Name
			)
		{
			_merchantId = 0;
			_creationTime = new DateTime(1970, 1, 1, 0, 0, 0);
		}
		
	
	}

}
