//generated automatically
import { log } from 'util';
import { Injectable } from '@angular/core'
import { Merchant } from './/Merchant'
import { Category } from './/Category'
export interface CategorizedMerchant
{
	categorizedMerchantId : number;
	categorieId : number;
	merchantId : number;
	creationTime : string;
	merchant : Merchant;
	categorie : Category;

}
