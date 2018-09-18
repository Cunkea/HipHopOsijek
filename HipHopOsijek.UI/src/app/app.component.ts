import { Component } from '@angular/core';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { StartComponent } from './start/start.component';
import { InfoComponent } from './info/info.component';
import { GuestsComponent } from './guests/guests.component';

@Component({
    selector: 'app-root',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css']
})

export class AppComponent {

    public loginComponent: LoginComponent;
    public registerComponent: RegisterComponent;
    public startComponent: StartComponent;
    public infoComponent: InfoComponent;
    public guestsComponent: GuestsComponent;


    constructor() {
        this.loginComponent = new LoginComponent();
        this.registerComponent = new RegisterComponent();
        this.startComponent = new StartComponent();
        this.infoComponent = new InfoComponent();
        this.guestsComponent = new GuestsComponent();
    }

    public change(name: string): void{
    	LoginComponent.show = false;
    	RegisterComponent.show = false;
    	StartComponent.show = false;
    	InfoComponent.show = false;
		GuestsComponent.show = false;

    	if(name == 's')
    	{
    		StartComponent.show = true;
		}
		else if(name == 'i')
		{
			InfoComponent.show = true;
		}
		else if(name == 'g')
		{
			GuestsComponent.show = true;
		}
    }
}
