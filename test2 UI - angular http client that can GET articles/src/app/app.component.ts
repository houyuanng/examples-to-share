import { Component } from '@angular/core';
import { RestService } from './rest.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'test2-ui';
  posts : any;
  constructor(private httpService: RestService) { }

  ngOnInit() {
    this.httpService.getPosts().subscribe(
    (response) => { this.posts = response; },
    (error) => { console.log(error); });
  }
  
}
