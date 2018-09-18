<<<<<<< HEAD
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { InfoComponent } from './info/info.component';
import { GuestsComponent } from './guests/guests.component';
import { StartComponent } from './start/start.component';


@NgModule({
    declarations: [AppComponent, LoginComponent, RegisterComponent, InfoComponent, GuestsComponent, StartComponent],
    imports: [BrowserModule],
    providers: [],
    bootstrap: [AppComponent]
})

export class AppModule {

}
=======
import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent }  from './app.component';

@NgModule({
  imports:      [ BrowserModule ],
  declarations: [ AppComponent ],
  bootstrap:    [ AppComponent ]
})
export class AppModule { }
>>>>>>> da79125be20029fe1834a86d1a88c9fa3fdede23
