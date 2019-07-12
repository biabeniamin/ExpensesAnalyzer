//generated automatically
import { log } from 'util';
import { Injectable } from '@angular/core'
import { Category } from './/Category'
import { Account } from './/Account'
export interface Transaction
{
	transactionId : number;
	accountId : number;
	categoryId : number;
	name : string;
	value : number;
	creationTime : string;
	categorie : Category;
	account : Account;

}
