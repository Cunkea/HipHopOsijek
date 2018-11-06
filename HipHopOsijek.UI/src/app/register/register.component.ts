import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  public static show: Boolean;

  constructor() {
  RegisterComponent.show = false;
  }

  get staticReg(){
  	return RegisterComponent.show;
  }

  public showRegister(): void{
  	if(RegisterComponent.show)
  		RegisterComponent.show = false;
  	else
  		RegisterComponent.show = true;
  }

  ngOnInit() {
  }

}
