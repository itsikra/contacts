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
            new Contact{FirstName="Carson"  ,LastName="Alexander" ,Email="2005-09-01", Phone="0500000000"},
            new Contact{FirstName="Meredith",LastName="Alonso"    ,Email="2002-09-01", Phone="0500000001"},
            new Contact{FirstName="Arturo"  ,LastName="Anand"     ,Email="2003-09-01", Phone="0500000002"},
            new Contact{FirstName="Gytis"   ,LastName="Barzdukas" ,Email="2002-09-01", Phone="0500000003"},
            new Contact{FirstName="Yan"     ,LastName="Li"        ,Email="2002-09-01", Phone="0500000004"},
            new Contact{FirstName="Peggy"   ,LastName="Justice"   ,Email="2001-09-01", Phone="0500000005"},
            new Contact{FirstName="Laura"   ,LastName="Norman"    ,Email="2003-09-01", Phone="0500000006"},
            new Contact{FirstName="Nino"    ,LastName="Olivetto"  ,Email="2005-09-01", Phone="0500000007"}
      };
      foreach (Contact s in contacts)
      {
        context.Contacts.Add(s);
      }
      context.SaveChanges();

      
    }
  }
}
