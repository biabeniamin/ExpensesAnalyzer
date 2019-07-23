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
public class TransactionAdapter extends BaseAdapter
{
	List<Transaction> transactions;
	Context context;
	
	@Override
	public int getCount()
	{
		return transactions.size();
	
	}
	
	@Override
	public View getView(int position, View convertView, ViewGroup parent)
	{
		Transaction transaction;
		TextView transactionIdTextBox;
		TextView accountIdTextBox;
		TextView merchantIdTextBox;
		TextView valueTextBox;
		TextView creationTimeTextBox;
		
		transaction = getItem(position);
		
		if(null == convertView)
		{
			convertView = LayoutInflater.from(context).inflate(R.layout.transaction_view, parent, false);
		}
		
		transactionIdTextBox = (TextView) convertView.findViewById(R.id.transactionIdTextBox);
		accountIdTextBox = (TextView) convertView.findViewById(R.id.accountIdTextBox);
		merchantIdTextBox = (TextView) convertView.findViewById(R.id.merchantIdTextBox);
		valueTextBox = (TextView) convertView.findViewById(R.id.valueTextBox);
		creationTimeTextBox = (TextView) convertView.findViewById(R.id.creationTimeTextBox);
		
		transactionIdTextBox.setText(transaction.getTransactionId().toString());
		accountIdTextBox.setText(transaction.getAccountId().toString());
		merchantIdTextBox.setText(transaction.getMerchantId().toString());
		valueTextBox.setText(transaction.getValue().toString());
		creationTimeTextBox.setText(transaction.getCreationTime().toString());
		
		return convertView;
	
	}
	
	@Override
	public Transaction getItem(int position)
	{
		return transactions.get(position);
	
	}
	
	@Override
	public long getItemId(int position)
	{
		return transactions.get(position).getTransactionId();
	
	}
	
	public TransactionAdapter(List<Transaction> transactions, Context context)
	{
		this.transactions = transactions;
		this.context = context;
	
	}
	

}
