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
public class AccountAdapter extends BaseAdapter
{
	List<Account> accounts;
	Context context;
	
	@Override
	public int getCount()
	{
		return accounts.size();
	
	}
	
	@Override
	public View getView(int position, View convertView, ViewGroup parent)
	{
		Account account;
		TextView accountIdTextBox;
		TextView emailTextBox;
		TextView passwordTextBox;
		TextView balanceTextBox;
		TextView creationTimeTextBox;
		
		account = getItem(position);
		
		if(null == convertView)
		{
			convertView = LayoutInflater.from(context).inflate(R.layout.account_view, parent, false);
		}
		
		accountIdTextBox = (TextView) convertView.findViewById(R.id.accountIdTextBox);
		emailTextBox = (TextView) convertView.findViewById(R.id.emailTextBox);
		passwordTextBox = (TextView) convertView.findViewById(R.id.passwordTextBox);
		balanceTextBox = (TextView) convertView.findViewById(R.id.balanceTextBox);
		creationTimeTextBox = (TextView) convertView.findViewById(R.id.creationTimeTextBox);
		
		accountIdTextBox.setText(account.getAccountId().toString());
		emailTextBox.setText(account.getEmail());
		passwordTextBox.setText(account.getPassword());
		balanceTextBox.setText(account.getBalance().toString());
		creationTimeTextBox.setText(account.getCreationTime().toString());
		
		return convertView;
	
	}
	
	@Override
	public Account getItem(int position)
	{
		return accounts.get(position);
	
	}
	
	@Override
	public long getItemId(int position)
	{
		return accounts.get(position).getAccountId();
	
	}
	
	public AccountAdapter(List<Account> accounts, Context context)
	{
		this.accounts = accounts;
		this.context = context;
	
	}
	

}
