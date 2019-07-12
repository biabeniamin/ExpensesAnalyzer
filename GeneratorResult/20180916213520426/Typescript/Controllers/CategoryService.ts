import {HttpClient} from '@angular/common/http';
import { ServerUrl } from './ServerUrl'
import { Injectable } from '@angular/core';
import { Category } from '../app/Models/Category'

@Injectable({
    providedIn : 'root'
})
export class CategoryService
{
	public categories : Category[];
	GetCategories()
	{
		return this.http.get<Category[]>(ServerUrl.GetUrl()  + "Categories.php?cmd=getCategories").subscribe(data =>
		{
			this.categories = data;
		});
	}
	
	GetLastCategory()
	{
		return this.http.get<Category[]>(ServerUrl.GetUrl()  + "Categories.php?cmd=getLastCategory");
	}
	
	static GetDefaultCategory()
	{
		return {
		categoryId : 0,
		name : 'Test',
		creationTime : '2000-01-01 00:00:00'
		};
	}
	
	constructor(private http:HttpClient)
	{
		this.categories = [CategoryService.GetDefaultCategory()];
		this.GetCategories();
	
	}
	
	AddCategory(categorie)
	{
		return this.http.post<Category>(ServerUrl.GetUrl()  + "Categories.php?cmd=addCategory", categorie).subscribe(categorie =>
		{
			console.log(categorie);
			if(0 != categorie.categoryId)
			{
				this.categories.push(categorie)
			}
		});
	}
	
	UpdateCategory(categorie)
	{
		return this.http.put<Category>(ServerUrl.GetUrl()  + "Categories.php?cmd=updateCategory", categorie).subscribe(categorie =>
		{
			console.log(categorie);
			return categorie;
		});
	}
	
	DeleteCategory(categorie)
	{
		return this.http.delete<Category>(ServerUrl.GetUrl()  + "Categories.php?cmd=deleteCategory&categoryId=" +  categorie.categoryId, ).subscribe(categorie =>
		{
			console.log(categorie);
			return categorie;
		});
	}
	
	GetCategoriesByCategoryId(categoryId)
	{
		return this.http.get<Category[]>(ServerUrl.GetUrl()  + `Categories.php?cmd=getCategoriesByCategoryId&categoryId=${categoryId}`);
	}
	

}
