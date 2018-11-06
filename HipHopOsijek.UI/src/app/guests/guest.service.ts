import { Injectable } from '@angular/core';
import { Http, Response, Headers, RequestOptions, RequestMethod } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/toPromise';

import { Guest } from './guest.model';

@Injectable()
export class GuestService {

    public guestList: Guest[];
    constructor(private http: Http) { }

    getGuests() {
        this.http.get('http://localhost:51199/api/Guests')
            .map((data: Response) => {
                return data.json() as Guest[];
            }).toPromise().then(x => {
                this.guestList = x;
            })
    }
}