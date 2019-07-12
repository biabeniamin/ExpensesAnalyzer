//generated automatically
package com.example.biabe.DatabaseFunctionsGenerator.Models;
import java.util.List;
import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;
import retrofit2.Retrofit;
import retrofit2.converter.gson.GsonConverterFactory;
import retrofit2.http.GET;
import retrofit2.http.Query;
import retrofit2.http.POST;
import retrofit2.http.Body;
import java.util.Date;

public class Category
{
	private Integer  categoryId;
	private String name;
	private Date creationTime;
	
	public Integer  getCategoryId()
	{
		return this.categoryId;
	}
	
	public void setCategoryId(Integer  categoryId)
	{
		this.categoryId = categoryId;
	}
	
	public String getName()
	{
		return this.name;
	}
	
	public void setName(String name)
	{
		this.name = name;
	}
	
	public Date getCreationTime()
	{
		return this.creationTime;
	}
	
	public void setCreationTime(Date creationTime)
	{
		this.creationTime = creationTime;
	}
	
	
	public Category(String name)
	{
		this.name = name;
	}
	
	public Category()
	{
		this(
			"Test" //Name
		);
		this.categoryId = 0;
		this.creationTime = new Date(0);
	
	}
	

}
