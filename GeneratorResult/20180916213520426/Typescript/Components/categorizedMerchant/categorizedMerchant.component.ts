import { Component, OnInit } from '@angular/core';
import { CategorizedMerchantService } from '../CategorizedMerchantService'
import {HttpClient} from '@angular/common/http';
import { FormControl, FormGroup } from '@angular/forms';
import { MerchantService } from '../MerchantService'
import { CategoryService } from '../CategoryService'

@Component({
selector: 'app-categorizedMerchant',
templateUrl: './categorizedMerchant.component.html',
styleUrls: ['./categorizedMerchant.component.css']
})
export class CategorizedMerchantComponent implements OnInit
{
	
	constructor(private http:HttpClient, 
		private categorizedMerchantService : CategorizedMerchantService, 
		private merchantService : MerchantService, 
		private categorieService : CategoryService
	)
	{
	
	}
	
	ngOnInit()
	{
	
	}
	
	addCategorizedMerchant(event)
	{
		event.preventDefault();
		const target = event.target;
		let categorizedMerchant = CategorizedMerchantService.GetDefaultCategorizedMerchant();
		categorizedMerchant.categoryId = target.querySelector('#CategoryIdDropDown').value;
		categorizedMerchant.merchantId = target.querySelector('#MerchantIdDropDown').value;
		console.log(categorizedMerchant);
		this.categorizedMerchantService.AddCategorizedMerchant(categorizedMerchant);
	}
	
	merchantChanged(event)
	{
		console.log(event);
	
	}
	
	categorieChanged(event)
	{
		console.log(event);
	
	}
	

}

