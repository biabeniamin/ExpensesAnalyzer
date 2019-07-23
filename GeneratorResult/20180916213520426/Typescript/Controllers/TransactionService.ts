import {HttpClient} from '@angular/common/http';
import { ServerUrl } from './ServerUrl'
import { Injectable } from '@angular/core';
import { Transaction } from '../app/Models/Transaction'
import { Merchant } from '../app/Models/Merchant'
import { MerchantService } from './MerchantService'
import { Account } from '../app/Models/Account'
import { AccountService } from './AccountService'

@Injectable({
    providedIn : 'root'
})
export class TransactionService
{
	public transactions : Transaction[];
	GetTransactions()
	{
		return this.http.get<Transaction[]>(ServerUrl.GetUrl()  + "Transactions.php?cmd=getTransactions").subscribe(data =>
		{
			this.transactions = data;
		});
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
		merchantId : 0,
		value : 0,
		creationTime : '2000-01-01 00:00:00',
		merchant : MerchantService.GetDefaultMerchant(),
		account : AccountService.GetDefaultAccount()
		};
	}
	
	constructor(private http:HttpClient)
	{
		this.transactions = [TransactionService.GetDefaultTransaction()];
		this.GetTransactions();
	
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
