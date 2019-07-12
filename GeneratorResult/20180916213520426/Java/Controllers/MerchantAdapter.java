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
public class MerchantAdapter extends BaseAdapter
{
	List<Merchant> merchants;
	Context context;
	
	@Override
	public int getCount()
	{
		return merchants.size();
	
	}
	
	@Override
	public View getView(int position, View convertView, ViewGroup parent)
	{
		Merchant merchant;
		TextView merchantIdTextBox;
		TextView nameTextBox;
		TextView creationTimeTextBox;
		
		merchant = getItem(position);
		
		if(null == convertView)
		{
			convertView = LayoutInflater.from(context).inflate(R.layout.merchant_view, parent, false);
		}
		
		merchantIdTextBox = (TextView) convertView.findViewById(R.id.merchantIdTextBox);
		nameTextBox = (TextView) convertView.findViewById(R.id.nameTextBox);
		creationTimeTextBox = (TextView) convertView.findViewById(R.id.creationTimeTextBox);
		
		merchantIdTextBox.setText(merchant.getMerchantId().toString());
		nameTextBox.setText(merchant.getName());
		creationTimeTextBox.setText(merchant.getCreationTime().toString());
		
		return convertView;
	
	}
	
	@Override
	public Merchant getItem(int position)
	{
		return merchants.get(position);
	
	}
	
	@Override
	public long getItemId(int position)
	{
		return merchants.get(position).getMerchantId();
	
	}
	
	public MerchantAdapter(List<Merchant> merchants, Context context)
	{
		this.merchants = merchants;
		this.context = context;
	
	}
	

}
