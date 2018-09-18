import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-guests',
  templateUrl: './guests.component.html',
  styleUrls: ['./guests.component.css']
})
export class GuestsComponent implements OnInit {

	static show: Boolean;

  constructor() {
  GuestsComponent.show = false;
  }

  get staticGuests(){
  	return GuestsComponent.show;
  }
  
  ngOnInit() {
  }

}
