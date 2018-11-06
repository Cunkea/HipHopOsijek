import { Component, OnInit } from '@angular/core';

import { Event } from './event/event.model';
import { EventService } from './event/event.service';

@Component({
  selector: 'app-start',
  templateUrl: './start.component.html',
  styleUrls: ['./start.component.css'],
  providers: [EventService]
})
export class StartComponent implements OnInit {

	static show: Boolean;

  constructor(private eventService: EventService) {
  StartComponent.show = true;
  }

  get staticStart(){
  	return StartComponent.show;
  }

  ngOnInit() {
    this.eventService.getEvents();
  }

}
