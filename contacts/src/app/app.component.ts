import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http'
@Component({
   selector: 'app-root',
   templateUrl: './app.component.html',
   styleUrls: ['./app.component.css']
})

export class AppComponent implements OnInit {
    constructor(private _httpService: Http) { }
   public  title: string = "Hello!";
   public apiValues: Contact[] =  [];
   ngOnInit() {
      this._httpService.get('/api/values').subscribe(values => {
          this.apiValues = values.json() as Contact[];
          console.log(this.apiValues);
      });
   }

   buttonClicked() {
       
       alert('clicked');
   }
}

export interface Contact {
    FirstName: string;
    LastName: string;
    Email: string;
    Phone: string;

}
