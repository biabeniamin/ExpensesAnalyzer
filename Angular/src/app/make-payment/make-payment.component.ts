import { Component, OnInit } from '@angular/core';
import { TransactionService } from '../Controllers/TransactionService';
import { CategorieService } from '../Controllers/CategorieService';
import { AccountService } from '../Controllers/AccountService';
import { Transaction } from '../Models/Transaction';
import { MerchantService } from '../Controllers/MerchantService';

declare var $:any;

@Component({
  selector: 'app-make-payment',
  templateUrl: './make-payment.component.html',
  styleUrls: ['./make-payment.component.scss']
})
export class MakePaymentComponent implements OnInit {
  name:string;
  value:number;
  public paymentDate : string = "2019-08-01";//new Date(Date.now()).toString("%yyyy-%MM-%dd");
  constructor(private transactionService : TransactionService, 
    private categorieService : CategorieService, 
    private accountService : AccountService,
    private merchantService : MerchantService) { }

  handlePaymentSubmit(){
    if(!this.name || !this.value) return;
    const {name, value} = this;
    const transaction = TransactionService.GetDefaultTransaction();
    if(this.transactionService.AddTransaction({...transaction,name, value, accountId: 1} as Transaction)){
      this.value = null;
      this.name = "";
      return $.notify({
        icon: "pe-7s-check",
        message: "Your transaction was successfully made"
    },{
        type: "success",
        timer: 1000,
        placement: {
            from: "top",
            align: "right"
        }
    });
    }
    return $.notify({
      icon: "pe-7s-close",
      message: "There was an error and we couldn't process your transaction"
  },{
      type: "danger",
      timer: 3000,
      placement: {
          from: "top",
          align: "right"
      }
  });
  }
  ngOnInit() {
    this.paymentDate=new Date(Date.now()).getFullYear()+"-";
    if(new Date(Date.now()).getMonth()< 10)
      this.paymentDate +="0";
    this.paymentDate += (new Date(Date.now()).getMonth() + 1)+"-";

    if(new Date(Date.now()).getDay()< 10)
      this.paymentDate +="0";
    this.paymentDate += (new Date(Date.now()).getUTCDate());
    
  }

  addTransaction(event)
	{
		event.preventDefault();
		const target = event.target;
		let transaction = TransactionService.GetDefaultTransaction();
    transaction.accountId = target.querySelector('#AccountIdDropDown').value;
    transaction.merchantId = target.querySelector('#MerchantIdDropDown').value;
    transaction.creationTime = new Date(target.querySelector('#TransactionDate').value).toString();
    console.log(target.querySelector('#TransactionDate').value);
    console.log(transaction.creationTime);
		//transaction.categoryId = target.querySelector('#CategoryIdDropDown').value;
		//transaction.name = target.querySelector('#Name').value;
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
