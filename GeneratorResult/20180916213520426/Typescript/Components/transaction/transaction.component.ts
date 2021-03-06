import { Component, OnInit } from '@angular/core';
import { TransactionService } from '../TransactionService'
import {HttpClient} from '@angular/common/http';
import { FormControl, FormGroup } from '@angular/forms';
import { MerchantService } from '../MerchantService'
import { AccountService } from '../AccountService'

@Component({
selector: 'app-transaction',
templateUrl: './transaction.component.html',
styleUrls: ['./transaction.component.css']
})
export class TransactionComponent implements OnInit
{
	
	constructor(private http:HttpClient, 
		private transactionService : TransactionService, 
		private merchantService : MerchantService, 
		private accountService : AccountService
	)
	{
	
	}
	
	ngOnInit()
	{
	
	}
	
	addTransaction(event)
	{
		event.preventDefault();
		const target = event.target;
		let transaction = TransactionService.GetDefaultTransaction();
		transaction.accountId = target.querySelector('#AccountIdDropDown').value;
		transaction.merchantId = target.querySelector('#MerchantIdDropDown').value;
		transaction.value = target.querySelector('#Value').value;
		console.log(transaction);
		this.transactionService.AddTransaction(transaction);
	}
	
	merchantChanged(event)
	{
		console.log(event);
	
	}
	
	accountChanged(event)
	{
		console.log(event);
	
	}
	

}

