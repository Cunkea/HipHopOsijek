import { Injectable } from '@angular/core';
import { Http, Response, Headers, RequestOptions, RequestMethod } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/toPromise';

import { Event } from './event.model';

@Injectable()
export class EventService {

    public eventList: Event[];
    constructor(private http: Http) { }

    getEvents() {
        this.http.get('http://localhost:51199/api/Events')
            .map((data: Response) => {
                return data.json() as Event[];
            }).toPromise().then(x => {
                this.eventList = x;
            })
    }
}