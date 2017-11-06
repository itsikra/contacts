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
        public IEnumerable<Contact> Get()
        {
          
            MScontacts_DbContext _context = new MScontacts_DbContext();


      //Contact a = new Contact();
      //a.FirstName = "Dan";
      //a.LastName = "Hadari";
      //a.Email = "DanHadari@gmail.com";
      //a.Phone = "054-500000";
      //contacts.Add(a);
      //Contact b = new Contact();
      //b.FirstName = "Itsik";
      //b.LastName = "Rafael";
      //b.Email = "itsik.mta@gmail.com";
      //b.Phone = "050-4401201";
      //contacts.Add(b);

      
            return Database.contactList.AsEnumerable() ;
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
            //c.FirstName = "yyyyy";
            //c.LastName = "Rafael";
            //c.Email = "itsik.mta@gmail.com";
            //c.Phone = "050-4401201";
            //contacts.Add(c);
            return Database.contactList.AsEnumerable();
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
