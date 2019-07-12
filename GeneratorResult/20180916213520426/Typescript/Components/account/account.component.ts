import { Component, OnInit } from '@angular/core';
import { AccountService } from '../AccountService'
import {HttpClient} from '@angular/common/http';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
selector: 'app-account',
templateUrl: './account.component.html',
styleUrls: ['./account.component.css']
})
export class AccountComponent implements OnInit
{
	
	constructor(private http:HttpClient, 
		private accountService : AccountService
	)
	{
	
	}
	
	ngOnInit()
	{
	
	}
	
	addAccount(event)
	{
		event.preventDefault();
		const target = event.target;
		let account = AccountService.GetDefaultAccount();
		account.email = target.querySelector('#Email').value;
		account.password = target.querySelector('#Password').value;
		account.balance = target.querySelector('#Balance').value;
		console.log(account);
		this.accountService.AddAccount(account);
	}
	

}

