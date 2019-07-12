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
public class CategorizedMerchantAdapter extends BaseAdapter
{
	List<CategorizedMerchant> categorizedMerchants;
	Context context;
	
	@Override
	public int getCount()
	{
		return categorizedMerchants.size();
	
	}
	
	@Override
	public View getView(int position, View convertView, ViewGroup parent)
	{
		CategorizedMerchant categorizedMerchant;
		TextView categorizedMerchantIdTextBox;
		TextView categoryIdTextBox;
		TextView merchantIdTextBox;
		TextView creationTimeTextBox;
		
		categorizedMerchant = getItem(position);
		
		if(null == convertView)
		{
			convertView = LayoutInflater.from(context).inflate(R.layout.categorizedmerchant_view, parent, false);
		}
		
		categorizedMerchantIdTextBox = (TextView) convertView.findViewById(R.id.categorizedMerchantIdTextBox);
		categoryIdTextBox = (TextView) convertView.findViewById(R.id.categoryIdTextBox);
		merchantIdTextBox = (TextView) convertView.findViewById(R.id.merchantIdTextBox);
		creationTimeTextBox = (TextView) convertView.findViewById(R.id.creationTimeTextBox);
		
		categorizedMerchantIdTextBox.setText(categorizedMerchant.getCategorizedMerchantId().toString());
		categoryIdTextBox.setText(categorizedMerchant.getCategoryId().toString());
		merchantIdTextBox.setText(categorizedMerchant.getMerchantId().toString());
		creationTimeTextBox.setText(categorizedMerchant.getCreationTime().toString());
		
		return convertView;
	
	}
	
	@Override
	public CategorizedMerchant getItem(int position)
	{
		return categorizedMerchants.get(position);
	
	}
	
	@Override
	public long getItemId(int position)
	{
		return categorizedMerchants.get(position).getCategorizedMerchantId();
	
	}
	
	public CategorizedMerchantAdapter(List<CategorizedMerchant> categorizedMerchants, Context context)
	{
		this.categorizedMerchants = categorizedMerchants;
		this.context = context;
	
	}
	

}
