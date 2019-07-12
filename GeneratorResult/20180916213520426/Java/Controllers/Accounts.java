//generated automatically
package com.example.biabe.DatabaseFunctionsGenerator;
import com.example.biabe.DatabaseFunctionsGenerator.Models.*;
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
interface AccountService
{
	@GET("Accounts.php?cmd=getAccounts")
	Call<List<Account>> getAccounts();
	
	@GET("Accounts.php?cmd=getAccountsByEmailPassword")
	Call<List<Account>> getAccountsByEmailPassword(@Query("email")String email, @Query("password")String password);
	
	@GET("Accounts.php?cmd=getAccountsByAccountId")
	Call<List<Account>> getAccountsByAccountId(@Query("accountId")Integer  accountId);
	
	@POST("Accounts.php?cmd=addAccount")
	Call<Account> addAccount(@Body Account account);

}

public class Accounts
{
	public static List<Account> getAccounts(Call<List<Account>> call)
	{
		List<Account> accounts;
		
		accounts = null;
		
		try
		{
			accounts = call.execute().body();
		}
		catch(Exception ee)
		{
			System.out.println(ee.getMessage());
		}
		
		return accounts;
	
	}
	public static List<Account> getAccounts()
	{
		List<Account> accounts;
		AccountService service;
		Call<List<Account>> call;
		
		accounts = null;
		
		service = RetrofitInstance.GetRetrofitInstance().create(AccountService.class);
		try
		{
			call = service.getAccounts();
			accounts = getAccounts(call);
		}
		catch(Exception ee)
		{
			System.out.println(ee.getMessage());
		}
		
		return accounts;
	
	}
	
	public static List<Account> getAccountsByEmailPassword(String email, String password)
	{
		List<Account> accounts;
		AccountService service;
		Call<List<Account>> call;
		
		accounts = null;
		
		service = RetrofitInstance.GetRetrofitInstance().create(AccountService.class);
		try
		{
			call = service.getAccountsByEmailPassword(email, password);
			accounts = getAccounts(call);
		}
		catch(Exception ee)
		{
			System.out.println(ee.getMessage());
		}
		
		return accounts;
	
	}
	
	public static List<Account> getAccountsByAccountId(Integer  accountId)
	{
		List<Account> accounts;
		AccountService service;
		Call<List<Account>> call;
		
		accounts = null;
		
		service = RetrofitInstance.GetRetrofitInstance().create(AccountService.class);
		try
		{
			call = service.getAccountsByAccountId(accountId);
			accounts = getAccounts(call);
		}
		catch(Exception ee)
		{
			System.out.println(ee.getMessage());
		}
		
		return accounts;
	
	}
	
	
	public static void getAccounts(Call<List<Account>> call, Callback<List<Account>> callback)
	{
		try
		{
			call.enqueue(callback);
		}
		catch(Exception ee)
		{
			System.out.println(ee.getMessage());
		}
		
	
	}
	public static void getAccounts(Callback<List<Account>> callback)
	{
		List<Account> accounts;
		AccountService service;
		Call<List<Account>> call;
		
		accounts = null;
		
		service = RetrofitInstance.GetRetrofitInstance().create(AccountService.class);
		try
		{
			call = service.getAccounts();
			getAccounts(call, callback);
		}
		catch(Exception ee)
		{
			System.out.println(ee.getMessage());
		}
		
	
	}
	
	public static void getAccountsByEmailPassword(String email, String password, Callback<List<Account>> callback)
	{
		List<Account> accounts;
		AccountService service;
		Call<List<Account>> call;
		
		accounts = null;
		
		service = RetrofitInstance.GetRetrofitInstance().create(AccountService.class);
		try
		{
			call = service.getAccountsByEmailPassword(email, password);
			getAccounts(call, callback);
		}
		catch(Exception ee)
		{
			System.out.println(ee.getMessage());
		}
		
	
	}
	
	public static void getAccountsByAccountId(Integer  accountId, Callback<List<Account>> callback)
	{
		List<Account> accounts;
		AccountService service;
		Call<List<Account>> call;
		
		accounts = null;
		
		service = RetrofitInstance.GetRetrofitInstance().create(AccountService.class);
		try
		{
			call = service.getAccountsByAccountId(accountId);
			getAccounts(call, callback);
		}
		catch(Exception ee)
		{
			System.out.println(ee.getMessage());
		}
		
	
	}
	
	
	public static Account addAccount(Account account)
	{
		AccountService service;
		Call<Account> call;
		
		
		service = RetrofitInstance.GetRetrofitInstance().create(AccountService.class);
		try
		{
			call = service.addAccount(account);
			account = call.execute().body();
		}
		catch(Exception ee)
		{
			System.out.println(ee.getMessage());
		}
		
		return account;
	
	}
	
	public static void addAccount(Account account, Callback<Account> callback)
	{
		AccountService service;
		Call<Account> call;
		
		
		service = RetrofitInstance.GetRetrofitInstance().create(AccountService.class);
		try
		{
			call = service.addAccount(account);
			call.enqueue(callback);
		}
		catch(Exception ee)
		{
			System.out.println(ee.getMessage());
		}
	
	}
	

}
