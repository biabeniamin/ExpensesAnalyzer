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

public class Transaction
{
	private Integer  transactionId;
	private Integer  accountId;
	private Integer  categoryId;
	private String name;
	private double value;
	private Date creationTime;
	private Category categorie;
	private Account account;
	
	public Integer  getTransactionId()
	{
		return this.transactionId;
	}
	
	public void setTransactionId(Integer  transactionId)
	{
		this.transactionId = transactionId;
	}
	
	public Integer  getAccountId()
	{
		return this.accountId;
	}
	
	public void setAccountId(Integer  accountId)
	{
		this.accountId = accountId;
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
	
	public double getValue()
	{
		return this.value;
	}
	
	public void setValue(double value)
	{
		this.value = value;
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
	
	public Account getAccount()
	{
		return this.account;
	}
	
	public void setAccount(Account account)
	{
		this.account = account;
	}
	
	
	public Transaction(Integer  accountId, Integer  categoryId, String name, double value)
	{
		this.accountId = accountId;
		this.categoryId = categoryId;
		this.name = name;
		this.value = value;
	}
	
	public Transaction(Integer  accountId, Integer  categoryId, String name, double value, Category categorie, Account account)
	{
		this(
			0, //AccountId
			0, //CategoryId
			"Test", //Name
			0 //Value
		);
		this.categorie = categorie;
		this.account = account;
	
	}
	
	public Transaction()
	{
		this(
			0, //AccountId
			0, //CategoryId
			"Test", //Name
			0 //Value
		);
		this.transactionId = 0;
		this.creationTime = new Date(0);
	
	}
	

}
