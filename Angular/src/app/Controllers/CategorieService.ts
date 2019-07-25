import {HttpClient} from '@angular/common/http';
import { ServerUrl } from '../Helpers/ServerUrl'
import { Injectable } from '@angular/core';
import { Category } from '../Models/Category'
import Realtimify from '../Helpers/Realtimify';

@Injectable({
    providedIn : 'root'
})
export class CategorieService
{
	public categories : Category[];
	static GetDefaultCategorie()
	{
		return {
		categoryId : 0,
		name : 'Test',
		creationTime : '2000-01-01 00:00:00'
		};
	}
	constructor(private http:HttpClient)
	{
		this.categories = [CategorieService.GetDefaultCategorie()];
		this.GetCategories();
		this.http.get<Category[]>(ServerUrl.GetUrl()  + "Categories.php?cmd=getCategories").subscribe(cat => 
			{
				this.categories = cat;
			});
	
	}
	GetCategories()
	{
		return Realtimify(()=> this.http.get<Category[]>(ServerUrl.GetUrl()  + "Categories.php?cmd=getCategories"));
	}
	GetCategoryByValue()
	{
		return Realtimify(()=> this.http.get<Category[]>(ServerUrl.GetUrl()  + "Categories.php?cmd=getByValue"));
	}

	
	AddCategorie(categorie)
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
	
	UpdateCategorie(categorie)
	{
		return this.http.put<Category>(ServerUrl.GetUrl()  + "Categories.php?cmd=updateCategorie", categorie).subscribe(categorie =>
		{
			console.log(categorie);
			return categorie;
		});
	}
	
	DeleteCategorie(categorie)
	{
		return this.http.delete<Category>(ServerUrl.GetUrl()  + "Categories.php?cmd=deleteCategorie&categorieId=" +  categorie.categorieId, ).subscribe(categorie =>
		{
			console.log(categorie);
			return categorie;
		});
	}
	
	GetCategoriesByCategorieId(categorieId)
	{
		return this.http.get<Category[]>(ServerUrl.GetUrl()  + `Categories.php?cmd=getCategoriesByCategorieId&categorieId=${categorieId}`);
	}
	

}
