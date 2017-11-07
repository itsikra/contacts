using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using contacts.Models;

namespace contacts.Data
{
  public static class DbInitializer
  {
    public static void Initialize(MScontacts_DbContext context)
    {
      context.Database.EnsureCreated();

      // Look for any students.
      if (context.Contacts.Any())
      {
        return;   // DB has been seeded
      }

      var contacts = new Contact[]
      {
            //new Contact{first="Carson"  ,last="Alexander" ,email="2005-09-01", phone="0500000000"},
            //new Contact{first="Meredith",last="Alonso"    ,email="2002-09-01", phone="0500000001"},
            //new Contact{first="Arturo"  ,last="Anand"     ,email="2003-09-01", phone="0500000002"},
            //new Contact{first="Gytis"   ,last="Barzdukas" ,email="2002-09-01", phone="0500000003"},
            //new Contact{first="Yan"     ,last="Li"        ,email="2002-09-01", phone="0500000004"},
            //new Contact{first="Peggy"   ,last="Justice"   ,email="2001-09-01", phone="0500000005"},
            //new Contact{first="Laura"   ,last="Norman"    ,email="2003-09-01", phone="0500000006"},
            //new Contact{first="Nino"    ,last="Olivetto"  ,email="2005-09-01", phone="0500000007"}
      };
      foreach (Contact s in contacts)
      {
        context.Contacts.Add(s);
      }
      context.SaveChanges();

      
    }
  }
}
