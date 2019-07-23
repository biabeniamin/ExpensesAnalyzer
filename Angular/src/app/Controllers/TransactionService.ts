import {HttpClient} from '@angular/common/http';
import { ServerUrl } from '../Helpers/ServerUrl'
import { Injectable } from '@angular/core';
import { Transaction } from '../Models/Transaction'
import { Merchant } from '../Models/Merchant'
import { MerchantService } from './MerchantService'
import { CategorieService } from './CategorieService'
import { Account } from '../Models/Account'
import { AccountService } from './AccountService'
import Realtimify from '../Helpers/Realtimify';

@Injectable({
    providedIn : 'root'
})
export class TransactionService
{
	public transactions : Transaction[];
	GetTransactions()
	{
		return Realtimify(()=>this.http.get<Transaction[]>(ServerUrl.GetUrl()  + "Transactions.php?cmd=getTransactions"));
	}
	
	GetLastTransaction()
	{
		return this.http.get<Transaction[]>(ServerUrl.GetUrl()  + "Transactions.php?cmd=getLastTransaction");
	}
	
	static GetDefaultTransaction()
	{
		return {
		transactionId : 0,
		accountId : 0,
		categoryId : 0,
		merchantId : 0,
		value : 0,
		creationTime : '2000-01-01 00:00:00',
		merchant : MerchantService.GetDefaultMerchant(),
		categorie : CategorieService.GetDefaultCategorie(),
		account : AccountService.GetDefaultAccount()
		};
	}
	
	constructor(private http:HttpClient)
	{
		this.transactions = [TransactionService.GetDefaultTransaction()];
		this.GetTransactions();
	
	}

	GetTransactionspPerMonth()
	{
		return Realtimify(()=> this.http.get<any[]>(ServerUrl.GetUrl()  + "Transactions.php?cmd=getTransactionValuePerMonth"));
	}
	
	GetTransactionspPerDay()
	{
		return Realtimify(()=> this.http.get<any[]>(ServerUrl.GetUrl()  + "Transactions.php?cmd=getTransactionValuePerDay"));
	}
	
	AddTransaction(transaction)
	{
		return this.http.post<Transaction>(ServerUrl.GetUrl()  + "Transactions.php?cmd=addTransaction", transaction).subscribe(transaction =>
		{
			console.log(transaction);
			if(0 != transaction.transactionId)
			{
				this.transactions.push(transaction)
			}
		});
	}
	
	UpdateTransaction(transaction)
	{
		return this.http.put<Transaction>(ServerUrl.GetUrl()  + "Transactions.php?cmd=updateTransaction", transaction).subscribe(transaction =>
		{
			console.log(transaction);
			return transaction;
		});
	}
	
	DeleteTransaction(transaction)
	{
		return this.http.delete<Transaction>(ServerUrl.GetUrl()  + "Transactions.php?cmd=deleteTransaction&transactionId=" +  transaction.transactionId, ).subscribe(transaction =>
		{
			console.log(transaction);
			return transaction;
		});
	}
	
	GetTransactionsByTransactionId(transactionId)
	{
		return this.http.get<Transaction[]>(ServerUrl.GetUrl()  + `Transactions.php?cmd=getTransactionsByTransactionId&transactionId=${transactionId}`);
	}
	

}
