"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var login_component_1 = require("./login/login.component");
var register_component_1 = require("./register/register.component");
var start_component_1 = require("./start/start.component");
var info_component_1 = require("./info/info.component");
var guests_component_1 = require("./guests/guests.component");
var AppComponent = /** @class */ (function () {
    function AppComponent() {
        this.loginComponent = new login_component_1.LoginComponent();
        this.registerComponent = new register_component_1.RegisterComponent();
        this.startComponent = new start_component_1.StartComponent();
        this.infoComponent = new info_component_1.InfoComponent();
        this.guestsComponent = new guests_component_1.GuestsComponent();
    }
    AppComponent.prototype.change = function (name) {
        login_component_1.LoginComponent.show = false;
        register_component_1.RegisterComponent.show = false;
        start_component_1.StartComponent.show = false;
        info_component_1.InfoComponent.show = false;
        guests_component_1.GuestsComponent.show = false;
        if (name == 's') {
            start_component_1.StartComponent.show = true;
        }
        else if (name == 'i') {
            info_component_1.InfoComponent.show = true;
        }
        else if (name == 'g') {
            guests_component_1.GuestsComponent.show = true;
        }
    };
    AppComponent = __decorate([
        core_1.Component({
            selector: 'app-root',
            templateUrl: './app.component.html',
            styleUrls: ['./app.component.css']
        }),
        __metadata("design:paramtypes", [])
    ], AppComponent);
    return AppComponent;
}());
exports.AppComponent = AppComponent;
//# sourceMappingURL=app.component.js.map