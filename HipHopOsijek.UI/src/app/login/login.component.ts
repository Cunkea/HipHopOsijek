import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  static show: Boolean;

  constructor() {
  LoginComponent.show = false;
  }

  get staticLog(){
  	return LoginComponent.show;
  }

  public showLogIn(): void{
  	if(LoginComponent.show)
  		LoginComponent.show = false;
  	else
  		LoginComponent.show = true;
  }

  ngOnInit() {
  }

}
