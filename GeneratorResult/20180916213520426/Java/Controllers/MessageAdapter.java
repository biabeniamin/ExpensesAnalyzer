//generated automatically
package com.example.biabe.DatabaseFunctionsGenerator;
import com.example.biabe.DatabaseFunctionsGenerator.Models.*;
import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.TextView;
import java.util.List;
public class MessageAdapter extends BaseAdapter
{
	List<Message> messages;
	Context context;
	
	@Override
	public int getCount()
	{
		return messages.size();
	
	}
	
	@Override
	public View getView(int position, View convertView, ViewGroup parent)
	{
		Message message;
		TextView messageIdTextBox;
		TextView contentTextBox;
		TextView sourceTextBox;
		TextView creationTimeTextBox;
		
		message = getItem(position);
		
		if(null == convertView)
		{
			convertView = LayoutInflater.from(context).inflate(R.layout.message_view, parent, false);
		}
		
		messageIdTextBox = (TextView) convertView.findViewById(R.id.messageIdTextBox);
		contentTextBox = (TextView) convertView.findViewById(R.id.contentTextBox);
		sourceTextBox = (TextView) convertView.findViewById(R.id.sourceTextBox);
		creationTimeTextBox = (TextView) convertView.findViewById(R.id.creationTimeTextBox);
		
		messageIdTextBox.setText(message.getMessageId().toString());
		contentTextBox.setText(message.getContent());
		sourceTextBox.setText(message.getSource().toString());
		creationTimeTextBox.setText(message.getCreationTime().toString());
		
		return convertView;
	
	}
	
	@Override
	public Message getItem(int position)
	{
		return messages.get(position);
	
	}
	
	@Override
	public long getItemId(int position)
	{
		return messages.get(position).getMessageId();
	
	}
	
	public MessageAdapter(List<Message> messages, Context context)
	{
		this.messages = messages;
		this.context = context;
	
	}
	

}
