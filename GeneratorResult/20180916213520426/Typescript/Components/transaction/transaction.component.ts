import { Component, OnInit } from '@angular/core';
import { TransactionService } from '../TransactionService'
import {HttpClient} from '@angular/common/http';
import { FormControl, FormGroup } from '@angular/forms';
import { CategoryService } from '../CategoryService'
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
		private categorieService : CategoryService, 
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
		transaction.categoryId = target.querySelector('#CategoryIdDropDown').value;
		transaction.name = target.querySelector('#Name').value;
		transaction.value = target.querySelector('#Value').value;
		console.log(transaction);
		this.transactionService.AddTransaction(transaction);
	}
	
	categorieChanged(event)
	{
		console.log(event);
	
	}
	
	accountChanged(event)
	{
		console.log(event);
	
	}
	

}

