import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http'

@Component({
    selector: 'app-root',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css']
})

export class AppComponent implements OnInit {
    constructor(private _httpService: Http) { }
    public title: string = "WELCOME";
    private apiValues: Contact[] = [];
    private allContacts: Contact[];
    private filtered: Contact[] = [];
    private newContact: Contact = {
        first: "", last: "", email: "", phone: ""
    };
    private searchContact: Contact = {
        first: "", last: "", email: "", phone: ""
    };

    public searchPhrase: string = "";
    private first: string;
    private last: string;
    private email: string;
    private phone: string;

    ngOnInit() {
        this._httpService.get('/api/values', null).subscribe(values => {
            this.apiValues = this.allContacts = values.json() as Contact[];
            console.log(this.apiValues);
        });
    }

    buttonClicked(contact) {
        //console.log(this.searchPhrase);
        if (contact.first == null || !(contact.first.replace(/\s/g, '').length) ||
            contact.last == null || !(contact.last.replace(/\s/g, '').length) ||
            contact.phone == null || !(contact.phone.replace(/\s/g, '').length))
            alert("Please enter all required fields");
        else {
            console.log("first:" + contact.first);
            this._httpService.post('/api/values', contact).subscribe(values => {
                this.apiValues = values.json() as Contact[];
                contact.first = null;
                contact.last = null;
                contact.phone = null;
                contact.email = null;

                console.log(this.apiValues);
            });
        }
    }

    onSearch(event: any) { // without type info
        this.searchPhrase = event.target.value;
        var phrase = event.target.value;

        console.log(phrase);
        this.filtered = [];

        //console.log(filtered);
        if (phrase) {
            for (let c of this.allContacts) {
                console.log(c);
                var name = c.first;
                console.log(name);
                if (c.first.toLowerCase().indexOf(phrase) != -1) {
                    this.filtered.push(c);
                }
            }
            this.apiValues = this.filtered;
        }
        else {
            this.apiValues = this.allContacts;
        }
    }
}



export interface Contact {
    first: string;
    last: string;
    email: string;
    phone: string;

}
