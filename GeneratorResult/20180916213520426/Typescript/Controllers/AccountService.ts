import {HttpClient} from '@angular/common/http';
import { ServerUrl } from './ServerUrl'
import { Injectable } from '@angular/core';
import { Account } from '../app/Models/Account'

@Injectable({
    providedIn : 'root'
})
export class AccountService
{
	public accounts : Account[];
	GetAccounts()
	{
		return this.http.get<Account[]>(ServerUrl.GetUrl()  + "Accounts.php?cmd=getAccounts").subscribe(data =>
		{
			this.accounts = data;
		});
	}
	
	GetLastAccount()
	{
		return this.http.get<Account[]>(ServerUrl.GetUrl()  + "Accounts.php?cmd=getLastAccount");
	}
	
	static GetDefaultAccount()
	{
		return {
		accountId : 0,
		email : 'Test',
		password : 'Test',
		balance : 0,
		creationTime : '2000-01-01 00:00:00'
		};
	}
	
	constructor(private http:HttpClient)
	{
		this.accounts = [AccountService.GetDefaultAccount()];
		this.GetAccounts();
	
	}
	
	AddAccount(account)
	{
		return this.http.post<Account>(ServerUrl.GetUrl()  + "Accounts.php?cmd=addAccount", account).subscribe(account =>
		{
			console.log(account);
			if(0 != account.accountId)
			{
				this.accounts.push(account)
			}
		});
	}
	
	UpdateAccount(account)
	{
		return this.http.put<Account>(ServerUrl.GetUrl()  + "Accounts.php?cmd=updateAccount", account).subscribe(account =>
		{
			console.log(account);
			return account;
		});
	}
	
	DeleteAccount(account)
	{
		return this.http.delete<Account>(ServerUrl.GetUrl()  + "Accounts.php?cmd=deleteAccount&accountId=" +  account.accountId, ).subscribe(account =>
		{
			console.log(account);
			return account;
		});
	}
	
	GetAccountsByEmailPassword(email, password)
	{
		return this.http.get<Account[]>(ServerUrl.GetUrl()  + `Accounts.php?cmd=getAccountsByEmailPassword&email=${email}&password=${password}`);
	}
	GetAccountsByAccountId(accountId)
	{
		return this.http.get<Account[]>(ServerUrl.GetUrl()  + `Accounts.php?cmd=getAccountsByAccountId&accountId=${accountId}`);
	}
	

}
