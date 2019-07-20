import { Component, OnInit } from '@angular/core';
import { CategorieService } from '../../Controllers/CategorieService';

@Component({
  selector: 'app-add-category',
  templateUrl: './add-category.component.html',
  styleUrls: ['./add-category.component.scss']
})
export class AddCategoryComponent implements OnInit {

  constructor(private categorieService : CategorieService    ) { }

  ngOnInit() {
  }

  addCategory(event)
	{
		event.preventDefault();
		const target = event.target;
		let categorie = CategorieService.GetDefaultCategorie();
		categorie.name = target.querySelector('#Name').value;
		console.log(categorie);
		this.categorieService.AddCategorie(categorie);
	}

}
