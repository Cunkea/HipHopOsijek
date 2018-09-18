import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-start',
  templateUrl: './start.component.html',
  styleUrls: ['./start.component.css']
})
export class StartComponent implements OnInit {

	public static show: Boolean;

  constructor() {
  StartComponent.show = true;
  }

  get staticStart(){
  	return StartComponent.show;
  }

  ngOnInit() {
  }

}
