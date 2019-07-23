//generated automatically
import { log } from 'util';
import { Injectable } from '@angular/core'
import { Merchant } from './/Merchant'
import { Account } from './/Account'
export interface Transaction
{
	transactionId : number;
	accountId : number;
	merchantId : number;
	value : number;
	creationTime : string;
	merchant : Merchant;
	account : Account;

}
