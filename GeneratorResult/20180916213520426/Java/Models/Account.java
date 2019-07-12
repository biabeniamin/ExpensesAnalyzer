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

public class Account
{
	private Integer  accountId;
	private String email;
	private String password;
	private double balance;
	private Date creationTime;
	
	public Integer  getAccountId()
	{
		return this.accountId;
	}
	
	public void setAccountId(Integer  accountId)
	{
		this.accountId = accountId;
	}
	
	public String getEmail()
	{
		return this.email;
	}
	
	public void setEmail(String email)
	{
		this.email = email;
	}
	
	public String getPassword()
	{
		return this.password;
	}
	
	public void setPassword(String password)
	{
		this.password = password;
	}
	
	public double getBalance()
	{
		return this.balance;
	}
	
	public void setBalance(double balance)
	{
		this.balance = balance;
	}
	
	public Date getCreationTime()
	{
		return this.creationTime;
	}
	
	public void setCreationTime(Date creationTime)
	{
		this.creationTime = creationTime;
	}
	
	
	public Account(String email, String password, double balance)
	{
		this.email = email;
		this.password = password;
		this.balance = balance;
	}
	
	public Account()
	{
		this(
			"Test", //Email
			"Test", //Password
			0 //Balance
		);
		this.accountId = 0;
		this.creationTime = new Date(0);
	
	}
	

}
