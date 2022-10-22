import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'FreelanceAngular';
  modelarray: Array<any> = new Array<any>();

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.http.get("https://localhost:44323/api/user").subscribe(res => { console.log(res); this.show(res) }, err => console.log(err));
  }

  show(input: any) {
    this.modelarray = input
  }
}
