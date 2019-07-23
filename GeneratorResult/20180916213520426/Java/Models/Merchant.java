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

public class Merchant
{
	private Integer  merchantId;
	private Integer  categoryId;
	private String name;
	private Date creationTime;
	private Category categorie;
	
	public Integer  getMerchantId()
	{
		return this.merchantId;
	}
	
	public void setMerchantId(Integer  merchantId)
	{
		this.merchantId = merchantId;
	}
	
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
	
	public Category getCategory()
	{
		return this.categorie;
	}
	
	public void setCategory(Category categorie)
	{
		this.categorie = categorie;
	}
	
	
	public Merchant(Integer  categoryId, String name)
	{
		this.categoryId = categoryId;
		this.name = name;
	}
	
	public Merchant(Integer  categoryId, String name, Category categorie)
	{
		this(
			0, //CategoryId
			"Test" //Name
		);
		this.categorie = categorie;
	
	}
	
	public Merchant()
	{
		this(
			0, //CategoryId
			"Test" //Name
		);
		this.merchantId = 0;
		this.creationTime = new Date(0);
	
	}
	

}
