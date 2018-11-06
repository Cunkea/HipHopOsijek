import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-info',
  templateUrl: './info.component.html',
  styleUrls: ['./info.component.css']
})
export class InfoComponent implements OnInit {

	static show: Boolean;

  constructor() {
  InfoComponent.show = false;
  }

  get staticInfo(){
  	return InfoComponent.show;
  }
  
  ngOnInit() {
  }

}
