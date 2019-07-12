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
interface CategoryService
{
	@GET("Categories.php?cmd=getCategories")
	Call<List<Category>> getCategories();
	
	@GET("Categories.php?cmd=getCategoriesByCategoryId")
	Call<List<Category>> getCategoriesByCategoryId(@Query("categoryId")Integer  categoryId);
	
	@POST("Categories.php?cmd=addCategory")
	Call<Category> addCategory(@Body Category categorie);

}

public class Categories
{
	public static List<Category> getCategories(Call<List<Category>> call)
	{
		List<Category> categories;
		
		categories = null;
		
		try
		{
			categories = call.execute().body();
		}
		catch(Exception ee)
		{
			System.out.println(ee.getMessage());
		}
		
		return categories;
	
	}
	public static List<Category> getCategories()
	{
		List<Category> categories;
		CategoryService service;
		Call<List<Category>> call;
		
		categories = null;
		
		service = RetrofitInstance.GetRetrofitInstance().create(CategoryService.class);
		try
		{
			call = service.getCategories();
			categories = getCategories(call);
		}
		catch(Exception ee)
		{
			System.out.println(ee.getMessage());
		}
		
		return categories;
	
	}
	
	public static List<Category> getCategoriesByCategoryId(Integer  categoryId)
	{
		List<Category> categories;
		CategoryService service;
		Call<List<Category>> call;
		
		categories = null;
		
		service = RetrofitInstance.GetRetrofitInstance().create(CategoryService.class);
		try
		{
			call = service.getCategoriesByCategoryId(categoryId);
			categories = getCategories(call);
		}
		catch(Exception ee)
		{
			System.out.println(ee.getMessage());
		}
		
		return categories;
	
	}
	
	
	public static void getCategories(Call<List<Category>> call, Callback<List<Category>> callback)
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
	public static void getCategories(Callback<List<Category>> callback)
	{
		List<Category> categories;
		CategoryService service;
		Call<List<Category>> call;
		
		categories = null;
		
		service = RetrofitInstance.GetRetrofitInstance().create(CategoryService.class);
		try
		{
			call = service.getCategories();
			getCategories(call, callback);
		}
		catch(Exception ee)
		{
			System.out.println(ee.getMessage());
		}
		
	
	}
	
	public static void getCategoriesByCategoryId(Integer  categoryId, Callback<List<Category>> callback)
	{
		List<Category> categories;
		CategoryService service;
		Call<List<Category>> call;
		
		categories = null;
		
		service = RetrofitInstance.GetRetrofitInstance().create(CategoryService.class);
		try
		{
			call = service.getCategoriesByCategoryId(categoryId);
			getCategories(call, callback);
		}
		catch(Exception ee)
		{
			System.out.println(ee.getMessage());
		}
		
	
	}
	
	
	public static Category addCategory(Category categorie)
	{
		CategoryService service;
		Call<Category> call;
		
		
		service = RetrofitInstance.GetRetrofitInstance().create(CategoryService.class);
		try
		{
			call = service.addCategory(categorie);
			categorie = call.execute().body();
		}
		catch(Exception ee)
		{
			System.out.println(ee.getMessage());
		}
		
		return categorie;
	
	}
	
	public static void addCategory(Category categorie, Callback<Category> callback)
	{
		CategoryService service;
		Call<Category> call;
		
		
		service = RetrofitInstance.GetRetrofitInstance().create(CategoryService.class);
		try
		{
			call = service.addCategory(categorie);
			call.enqueue(callback);
		}
		catch(Exception ee)
		{
			System.out.println(ee.getMessage());
		}
	
	}
	

}
