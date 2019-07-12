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
	public class CategorizedMerchant
	{
		private int _categorizedMerchantId;
		private int _categoryId;
		private int _merchantId;
		private DateTime _creationTime;
		private Merchant _merchant;
		private Category _categorie;
		
		[JsonProperty(PropertyName = "categorizedMerchantId")]
		public int CategorizedMerchantId
		{
			get
			{
				return _categorizedMerchantId;
			}
			set
			{
				_categorizedMerchantId = value;
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
		
		
		public CategorizedMerchant(int categorizedMerchantId, int categoryId, int merchantId, DateTime creationTime)
		{
			_categorizedMerchantId = categorizedMerchantId;
			_categoryId = categoryId;
			_merchantId = merchantId;
			_creationTime = creationTime;
		}
		
		public CategorizedMerchant(int categoryId, int merchantId)
		{
			_categoryId = categoryId;
			_merchantId = merchantId;
		}
		
		public CategorizedMerchant(int categoryId, int merchantId, Merchant merchant, Category categorie)
			:this(categoryId, merchantId)
		{
			_categoryId = categoryId;
			_merchantId = merchantId;
		}
		
		public CategorizedMerchant()
			 :this(
				0, //CategoryId
				0 //MerchantId
			)
		{
			_categorizedMerchantId = 0;
			_creationTime = new DateTime(1970, 1, 1, 0, 0, 0);
		}
		
	
	}

}
