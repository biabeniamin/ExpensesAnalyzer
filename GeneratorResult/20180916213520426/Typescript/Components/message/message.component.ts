import { Component, OnInit } from '@angular/core';
import { MessageService } from '../MessageService'
import {HttpClient} from '@angular/common/http';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
selector: 'app-message',
templateUrl: './message.component.html',
styleUrls: ['./message.component.css']
})
export class MessageComponent implements OnInit
{
	
	constructor(private http:HttpClient, 
		private messageService : MessageService
	)
	{
	
	}
	
	ngOnInit()
	{
	
	}
	
	addMessage(event)
	{
		event.preventDefault();
		const target = event.target;
		let message = MessageService.GetDefaultMessage();
		message.content = target.querySelector('#Content').value;
		message.source = target.querySelector('#Source').value;
		console.log(message);
		this.messageService.AddMessage(message);
	}
	

}

