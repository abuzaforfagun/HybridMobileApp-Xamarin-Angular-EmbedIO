import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  title = 'app';
  languageList: any;
  constructor(private http: HttpClient) {
    this.languageList = [];
  }
  ngOnInit(): void {
    let headers = new HttpHeaders();
    headers.append('Content-Type','application/json');
    headers.append('Accept', 'application/json');
    headers.append('Access-Control-Allow-Methods', 'POST, GET, OPTIONS, DELETE, PUT');
    headers.append('Access-Control-Allow-Origin', '*');

    this.http.get('http://localhost:8080/api/favouritelanguage', {
      headers: headers
    } ).subscribe(result => {
      this.languageList = result;
    });
    // this.languageList.push("C#");
    // this.languageList.push("TypeScript")
  }
}
