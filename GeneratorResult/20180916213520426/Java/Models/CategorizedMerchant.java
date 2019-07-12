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

public class CategorizedMerchant
{
	private Integer  categorizedMerchantId;
	private Integer  categoryId;
	private Integer  merchantId;
	private Date creationTime;
	private Merchant merchant;
	private Category categorie;
	
	public Integer  getCategorizedMerchantId()
	{
		return this.categorizedMerchantId;
	}
	
	public void setCategorizedMerchantId(Integer  categorizedMerchantId)
	{
		this.categorizedMerchantId = categorizedMerchantId;
	}
	
	public Integer  getCategoryId()
	{
		return this.categoryId;
	}
	
	public void setCategoryId(Integer  categoryId)
	{
		this.categoryId = categoryId;
	}
	
	public Integer  getMerchantId()
	{
		return this.merchantId;
	}
	
	public void setMerchantId(Integer  merchantId)
	{
		this.merchantId = merchantId;
	}
	
	public Date getCreationTime()
	{
		return this.creationTime;
	}
	
	public void setCreationTime(Date creationTime)
	{
		this.creationTime = creationTime;
	}
	
	public Merchant getMerchant()
	{
		return this.merchant;
	}
	
	public void setMerchant(Merchant merchant)
	{
		this.merchant = merchant;
	}
	
	public Category getCategory()
	{
		return this.categorie;
	}
	
	public void setCategory(Category categorie)
	{
		this.categorie = categorie;
	}
	
	
	public CategorizedMerchant(Integer  categoryId, Integer  merchantId)
	{
		this.categoryId = categoryId;
		this.merchantId = merchantId;
	}
	
	public CategorizedMerchant(Integer  categoryId, Integer  merchantId, Merchant merchant, Category categorie)
	{
		this(
			0, //CategoryId
			0 //MerchantId
		);
		this.merchant = merchant;
		this.categorie = categorie;
	
	}
	
	public CategorizedMerchant()
	{
		this(
			0, //CategoryId
			0 //MerchantId
		);
		this.categorizedMerchantId = 0;
		this.creationTime = new Date(0);
	
	}
	

}
