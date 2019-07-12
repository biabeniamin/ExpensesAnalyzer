import { Component, OnInit } from '@angular/core';
import { CategoryService } from '../CategoryService'
import {HttpClient} from '@angular/common/http';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
selector: 'app-categorie',
templateUrl: './categorie.component.html',
styleUrls: ['./categorie.component.css']
})
export class CategoryComponent implements OnInit
{
	
	constructor(private http:HttpClient, 
		private categorieService : CategoryService
	)
	{
	
	}
	
	ngOnInit()
	{
	
	}
	
	addCategory(event)
	{
		event.preventDefault();
		const target = event.target;
		let categorie = CategoryService.GetDefaultCategory();
		categorie.name = target.querySelector('#Name').value;
		console.log(categorie);
		this.categorieService.AddCategory(categorie);
	}
	

}

