import { Component, OnInit } from '@angular/core';
import { LocationStrategy, PlatformLocation, Location } from '@angular/common';
import * as Chartist from 'chartist';
import { CategorieService } from '../Controllers/CategorieService';
import { TransactionService } from '../Controllers/TransactionService';
import { MerchantService } from '../Controllers/MerchantService';

export const monthNames = ["January", "February", "March", "April", "May", "June",
"July", "August", "September", "October", "November", "December"
];

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
    public categoryData:any[];
    public categoryLabels:any[];
    public incomeData:any[];
    public incomeLabels:any[];
    public monthTransactionsData:any[];
    public monthTransactionsLabels:any[];
    public dayTransactionsData:any[];
    public dayTransactionsLabels:any[];
    public months : [string, number][]=[["All", 0],["Jan", 1],["Feb", 2],["Mar", 3],["Apr", 4],["May", 5],["Jun", 6],["Jul", 7],["Aug", 8],["Sep", 9],["Oct", 10],["Nov", 11],["Dec", 12],];
    public selectedMonth : number = 0;
    constructor(private categoryService: CategorieService, private transactionsService: TransactionService, private merchantService: MerchantService) { }
    async ngOnInit() {
      setInterval(() => {

    
          this.categoryService.GetCategoryByValueByMonth(this.selectedMonth).subscribe((values:any[])=>{
            
            this.categoryData = [];
            this.categoryLabels = [];
            values.map(value=>{
            if (value.value < 0)
            {
              //this.incomeData.push(value.value);
            // this.incomeLabels.push(value.name);
            }
            else if (value.value > 0)
            {
              //console.log(value);
              this.categoryData.push(value.value);
              this.categoryLabels.push(value.name);
            }
          })
        });
      }, 3000);

      setInterval(() => {
        console.log(this.selectedMonth);
        this.merchantService.GetMerchantByValueByMonth(this.selectedMonth).subscribe((values:any[])=>{
          console.log(values);
          this.incomeData = [];
          this.incomeLabels = [];
           values.map(value=>{
          if (value.value < 0)
          {
              this.incomeData.push(value.value);
              this.incomeLabels.push(value.name);
          }
          else if (value.value > 0)
          {
          }
        })
      });
  
      }, 6000);
      



    this.transactionsService.GetTransactionspPerMonth().subscribe((values:any[])=>{
      this.monthTransactionsData = [];
      this.monthTransactionsLabels = [];
       values.map(value=>{
      this.monthTransactionsData.push(value.Value);
      this.monthTransactionsLabels.push(monthNames[value.Month -1]);
    })
  });
  this.transactionsService.GetTransactionspPerDay().subscribe((values:any[])=>{
    this.dayTransactionsData = [];
    this.dayTransactionsLabels = [];
     values.map(value=>{
    this.dayTransactionsData.push(value.Value);
    this.dayTransactionsLabels.push(value.Day);
  })
});
    }


  addCategory(event)
	{
    event.preventDefault();
    const target = event.target;
    
	}
}
