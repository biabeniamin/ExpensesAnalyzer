import { Component, OnInit } from '@angular/core';
import { HttpClient } from 'selenium-webdriver/http';
import { MerchantService } from '../Controllers/MerchantService';
import { CategorieService } from '../Controllers/CategorieService';

@Component({
  selector: 'app-add-merchant',
  templateUrl: './add-merchant.component.html',
  styleUrls: ['./add-merchant.component.scss']
})
export class AddMerchantComponent implements OnInit {

  constructor(
		private merchantService : MerchantService, 
		private categorieService : CategorieService) { }

  ngOnInit() {
  }

  addMerchant(event)
	{
		event.preventDefault();
		const target = event.target;
		let merchant = MerchantService.GetDefaultMerchant();
		merchant.categoryId = target.querySelector('#CategoryIdDropDown').value;
		merchant.name = target.querySelector('#Name').value;
		console.log(merchant);
		this.merchantService.AddMerchant(merchant);
	}


}
