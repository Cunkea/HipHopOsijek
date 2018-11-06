import { Component, OnInit } from '@angular/core';

import { Guest } from './guest.model';
import { GuestService } from './guest.service';

@Component({
  selector: 'app-guests',
  templateUrl: './guests.component.html',
  styleUrls: ['./guests.component.css'],
  providers: [GuestService]
})
export class GuestsComponent implements OnInit {

	static show: Boolean;

  constructor(private guestService: GuestService) {
  GuestsComponent.show = false;
  }

  get staticGuests(){
  	return GuestsComponent.show;
  }
  
  ngOnInit() {
    this.guestService.getGuests();
  }

}
