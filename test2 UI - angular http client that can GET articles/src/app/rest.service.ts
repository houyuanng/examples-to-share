import { Injectable } from '@angular/core';

import { catchError } from 'rxjs';

import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})

export class RestService {

  private url = 'https://my-json-server.typicode.com/JSGund/XHR-Fetch-Request-JavaScript/posts';
  // private url = 'https://localhost:7052/api/cat';
  constructor(private http: HttpClient) { }

  getPosts() {
    return this.http.get(this.url);
  }
  

}
