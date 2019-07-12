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
	public class Category
	{
		private int _categoryId;
		private string _name;
		private DateTime _creationTime;
		
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
		
		
		public Category(int categoryId, string name, DateTime creationTime)
		{
			_categoryId = categoryId;
			_name = name;
			_creationTime = creationTime;
		}
		
		public Category(string name)
		{
			_name = name;
		}
		
		public Category()
			 :this(
				"Test" //Name
			)
		{
			_categoryId = 0;
			_creationTime = new DateTime(1970, 1, 1, 0, 0, 0);
		}
		
	
	}

}
