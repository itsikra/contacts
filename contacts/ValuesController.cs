using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace contacts
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
    List<Contact> contacts = new List<Contact>();

    // GET: api/values
    [HttpGet]
        public IEnumerable<Contact> Get()
        {
      Contact a = new Contact();
      a.FirstName = "fname1";
      a.LastName = "lname1";
      a.Email = "fname1.lname1@gmail.com";
      a.Phone = "999999";
      contacts.Add(a);
      Contact b = new Contact();
      b.FirstName = "fname2";
      b.LastName = "lname2";
      b.Email = "fname2.lname2@gmail.com";
      b.Phone = "999999";
      contacts.Add(b);


      return contacts.AsEnumerable() ;
        }

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

         //POST api/values
        [HttpPost]
        public void Post([FromBody]Contact value)
        {
            contacts.Add(value);
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
