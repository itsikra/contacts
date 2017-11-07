using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using contacts.Models;
using contacts.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace contacts
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
    public static List<Contact> contacts = new List<Contact>();
    

    // GET: api/values
    [HttpGet]
        public IEnumerable<Contact> Get(string searchPhrase)
        {

      //MScontacts_DbContext _context = new MScontacts_DbContext();


      //Contact a = new Contact();       //a.first = "Dan";       //a.last = "Hadari";       //a.email = "DanHadari@gmail.com";
      //a.phone = "054-500000";       //contacts.Add(a);      //Contact b = new Contact();       //b.first = "Itsik";
      //b.last = "Rafael";      //b.email = "itsik.mta@gmail.com";      //b.phone = "050-4401201";      //contacts.Add(b);

      //string searchPhrase = searchContact.first;
      //searchPhrase = "a";
      //Console.WriteLine("From c: "+searchPhrase);

      if (!string.IsNullOrEmpty(searchPhrase))
      {
        return Database.contactList
          .Where(t => (t.first.ToLower().Contains(searchPhrase.ToLower())) ||
                      (t.last.ToLower().Contains(searchPhrase.ToLower())) ||
                      (t.email.ToLower().Contains(searchPhrase.ToLower())) ||
                      (t.phone.ToLower().Contains(searchPhrase.ToLower())))
           .OrderBy(t => t.first)
           .ThenBy(t => t.last);

      }
      else
      {
        return Database.contactList.OrderBy(t => t.first).ThenBy(t => t.last).AsEnumerable();
      }

     // return Database.contactList.AsEnumerable() 
      
        }

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

         //POST api/values
        [HttpPost]
        public IEnumerable<Contact> Post([FromBody]Contact value)
        {
            Database.contactList.Add(value);
      //Contact c = new Contact();
      //c.first = "yyyyy";
      //c.last = "Rafael";
      //c.email = "itsik.mta@gmail.com";
      //c.phone = "050-4401201";
      //contacts.Add(c);
      //string searchPhrase = "a";

      List<Contact> Filtered = new List<Contact>();
      //Filtered =
      //searchPhrase = "a";
      //if (!string.IsNullOrEmpty(searchPhrase))
      //{
      //  return Database.contactList
      //    .Where(t => (t.first.ToLower().Contains(searchPhrase.ToLower())) ||
      //                (t.last.ToLower().Contains(searchPhrase.ToLower())) ||
      //                (t.email.ToLower().Contains(searchPhrase.ToLower())) ||
      //                (t.phone.ToLower().Contains(searchPhrase.ToLower())))
      //     .OrderBy(t => t.first)
      //     .ThenBy(t => t.last);

      //}
      //else
      //{
        return Database.contactList.OrderBy(t => t.first).ThenBy(t => t.last).AsEnumerable();
      //}

      //var res = from item in Database.contactList
      //          select item
      //          where ()
      //return Database.contactList.AsEnumerable();
    }

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
