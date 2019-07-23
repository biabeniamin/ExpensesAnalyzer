//generated automatically
import { log } from 'util';
import { Injectable } from '@angular/core'
import { Merchant } from './/Merchant'
import { Category } from './/Category'
import { Account } from './/Account'
export interface Transaction
{
	transactionId : number;
	accountId : number;
	categoryId : number;
	merchantId : number;
	value : number;
	creationTime : string;
	merchant : Merchant;
	categorie : Category;
	account : Account;

}
