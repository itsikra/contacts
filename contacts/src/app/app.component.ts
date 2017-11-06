import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http'
@Component({
   selector: 'app-root',
   templateUrl: './app.component.html',
   styleUrls: ['./app.component.css']
})

export class AppComponent implements OnInit {
    constructor(private _httpService: Http) { }
   public  title: string = "WELCOME";
   private apiValues: Contact[] = [];
   private newContact: Contact = {
       FirstName: "",LastName: "",Email: "",Phone:""
   };
   private firstName: string;
   private lastName: string;
   private email: string;
   private phone: string;
   ngOnInit() {
      this._httpService.get('/api/values').subscribe(values => {
          this.apiValues = values.json() as Contact[];
          console.log(this.apiValues);
      });
   }

   buttonClicked(contact) {
       console.log(contact.firstName);
       this._httpService.post('/api/values', contact).subscribe(values => {
           this.apiValues = values.json() as Contact[];
           console.log(this.apiValues);
       });

       //this._httpService.get('/api/values').subscribe(values => {
       //    this.apiValues = values.json() as Contact[];
       //    console.log(this.apiValues);

       //    //this.apiValues.push({ FirstName: "w", LastName: "e", Email: "r", Phone: "t" });
       //    //this.apiValues.push({ FirstName: "wdd", LastName: "esfgsd", Email: "64r", Phone: "4" });
       //    //console.log(this.apiValues);
       //});
       
           //values => {
           //this.apiValues = values.json() as Contact[];
           //console.log(this.apiValues);

       
       //this._httpService.get('/api/values').subscribe(values => {
       //    this.apiValues = values.json() as Contact[];
       //    console.log(this.apiValues);
       //});

       //this._httpService.post('/api/values').subscribe(value => {
       //    this.apiValues = values.json() as Contact[];
       //    console.log(this.apiValues);
       //});
       //alert('clicked');
   }
}

export interface Contact {
    FirstName: string;
    LastName: string;
    Email: string;
    Phone: string;

}
