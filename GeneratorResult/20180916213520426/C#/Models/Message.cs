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
	public class Message
	{
		private int _messageId;
		private string _content;
		private int _source;
		private DateTime _creationTime;
		
		[JsonProperty(PropertyName = "messageId")]
		public int MessageId
		{
			get
			{
				return _messageId;
			}
			set
			{
				_messageId = value;
			}
		}
		
		[JsonProperty(PropertyName = "content")]
		public string Content
		{
			get
			{
				return _content;
			}
			set
			{
				_content = value;
			}
		}
		
		[JsonProperty(PropertyName = "source")]
		public int Source
		{
			get
			{
				return _source;
			}
			set
			{
				_source = value;
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
		
		
		public Message(int messageId, string content, int source, DateTime creationTime)
		{
			_messageId = messageId;
			_content = content;
			_source = source;
			_creationTime = creationTime;
		}
		
		public Message(string content, int source)
		{
			_content = content;
			_source = source;
		}
		
		public Message()
			 :this(
				"Test", //Content
				0 //Source
			)
		{
			_messageId = 0;
			_creationTime = new DateTime(1970, 1, 1, 0, 0, 0);
		}
		
	
	}

}
