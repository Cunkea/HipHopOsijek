"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
<<<<<<< HEAD
var platform_browser_1 = require("@angular/platform-browser");
var core_1 = require("@angular/core");
var app_component_1 = require("./app.component");
var login_component_1 = require("./login/login.component");
var register_component_1 = require("./register/register.component");
var info_component_1 = require("./info/info.component");
var guests_component_1 = require("./guests/guests.component");
var start_component_1 = require("./start/start.component");
=======
var core_1 = require("@angular/core");
var platform_browser_1 = require("@angular/platform-browser");
var app_component_1 = require("./app.component");
>>>>>>> da79125be20029fe1834a86d1a88c9fa3fdede23
var AppModule = /** @class */ (function () {
    function AppModule() {
    }
    AppModule = __decorate([
        core_1.NgModule({
<<<<<<< HEAD
            declarations: [app_component_1.AppComponent, login_component_1.LoginComponent, register_component_1.RegisterComponent, info_component_1.InfoComponent, guests_component_1.GuestsComponent, start_component_1.StartComponent],
            imports: [platform_browser_1.BrowserModule],
            providers: [],
=======
            imports: [platform_browser_1.BrowserModule],
            declarations: [app_component_1.AppComponent],
>>>>>>> da79125be20029fe1834a86d1a88c9fa3fdede23
            bootstrap: [app_component_1.AppComponent]
        })
    ], AppModule);
    return AppModule;
}());
exports.AppModule = AppModule;
//# sourceMappingURL=app.module.js.map