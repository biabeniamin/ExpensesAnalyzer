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
public class CategoryAdapter extends BaseAdapter
{
	List<Category> categories;
	Context context;
	
	@Override
	public int getCount()
	{
		return categories.size();
	
	}
	
	@Override
	public View getView(int position, View convertView, ViewGroup parent)
	{
		Category categorie;
		TextView categoryIdTextBox;
		TextView nameTextBox;
		TextView creationTimeTextBox;
		
		categorie = getItem(position);
		
		if(null == convertView)
		{
			convertView = LayoutInflater.from(context).inflate(R.layout.categorie_view, parent, false);
		}
		
		categoryIdTextBox = (TextView) convertView.findViewById(R.id.categoryIdTextBox);
		nameTextBox = (TextView) convertView.findViewById(R.id.nameTextBox);
		creationTimeTextBox = (TextView) convertView.findViewById(R.id.creationTimeTextBox);
		
		categoryIdTextBox.setText(categorie.getCategoryId().toString());
		nameTextBox.setText(categorie.getName());
		creationTimeTextBox.setText(categorie.getCreationTime().toString());
		
		return convertView;
	
	}
	
	@Override
	public Category getItem(int position)
	{
		return categories.get(position);
	
	}
	
	@Override
	public long getItemId(int position)
	{
		return categories.get(position).getCategoryId();
	
	}
	
	public CategoryAdapter(List<Category> categories, Context context)
	{
		this.categories = categories;
		this.context = context;
	
	}
	

}
