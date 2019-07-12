import { Component, OnInit } from '@angular/core';
import { MerchantService } from '../MerchantService'
import {HttpClient} from '@angular/common/http';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
selector: 'app-merchant',
templateUrl: './merchant.component.html',
styleUrls: ['./merchant.component.css']
})
export class MerchantComponent implements OnInit
{
	
	constructor(private http:HttpClient, 
		private merchantService : MerchantService
	)
	{
	
	}
	
	ngOnInit()
	{
	
	}
	
	addMerchant(event)
	{
		event.preventDefault();
		const target = event.target;
		let merchant = MerchantService.GetDefaultMerchant();
		merchant.name = target.querySelector('#Name').value;
		console.log(merchant);
		this.merchantService.AddMerchant(merchant);
	}
	

}

