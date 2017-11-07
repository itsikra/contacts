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
   private searchContact: Contact = {
       FirstName: "", LastName: "", Email: "", Phone: ""
   };


   public searchPhrase: string = "";
   private firstName: string;
   private lastName: string;
   private email: string;
   private phone: string;
   ngOnInit() {
       this._httpService.get('/api/values', null).subscribe(values => {
          this.apiValues = values.json() as Contact[];
          console.log(this.apiValues);
      });
   }

   buttonClicked(contact) {
       //console.log(this.searchPhrase);
       if (contact.firstName == null || !(contact.firstName.replace(/\s/g, '').length) || 
           contact.lastName == null || !(contact.lastName.replace(/\s/g, '').length) || 
           contact.phone == null || !(contact.phone.replace(/\s/g, '').length) )
           alert("Please enter all required fields");
       else {
           console.log("FirstName:" + contact.firstName);
           this._httpService.post('/api/values', contact).subscribe(values => {
               this.apiValues = values.json() as Contact[];
               contact.firstName = null;
               contact.lastName = null;
               contact.phone = null;
               contact.email = null;

               console.log(this.apiValues);
           });
       }

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

   onSearch(event: any) { // without type info
       this.searchPhrase = event.target.value;
       this.searchContact.FirstName = "A";
       console.log(this.searchPhrase);
       this._httpService.get('/api/values', "z").subscribe(values => {
           this.apiValues = values.json() as Contact[];
       });
    }




}

export interface Contact {
    FirstName: string;
    LastName: string;
    Email: string;
    Phone: string;

}
