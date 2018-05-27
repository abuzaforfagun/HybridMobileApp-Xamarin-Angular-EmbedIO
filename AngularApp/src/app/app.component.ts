import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  languageList: any;
  language: string;
  constructor(private http: HttpClient) {
    this.languageList = [];
  }
  ngOnInit(): void {
    this.http.get('http://localhost:8080/api/favouritelanguage').subscribe(result => {
      this.languageList = result;
    });
  }

  addNewLanguage() {
    this.http.post('http://localhost:8080/api/favouritelanguage', this.language).subscribe(
      data => {
        this.languageList = data;
      }
    );
  }
}
