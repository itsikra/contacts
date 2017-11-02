using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using contacts.Models;

namespace contacts.Data
{
  public static class DbInitializer
  {
    public static void Initialize(MScontacts_dnContext context)
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

      //var courses = new Course[]
      //{
      //      new Course{CourseID=1050,Title="Chemistry",Credits=3},
      //      new Course{CourseID=4022,Title="Microeconomics",Credits=3},
      //      new Course{CourseID=4041,Title="Macroeconomics",Credits=3},
      //      new Course{CourseID=1045,Title="Calculus",Credits=4},
      //      new Course{CourseID=3141,Title="Trigonometry",Credits=4},
      //      new Course{CourseID=2021,Title="Composition",Credits=3},
      //      new Course{CourseID=2042,Title="Literature",Credits=4}
      //};
      //foreach (Course c in courses)
      //{
      //  context.Courses.Add(c);
      //}
      //context.SaveChanges();

      //var enrollments = new Enrollment[]
      //{
      //      new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
      //      new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
      //      new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
      //      new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
      //      new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
      //      new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
      //      new Enrollment{StudentID=3,CourseID=1050},
      //      new Enrollment{StudentID=4,CourseID=1050},
      //      new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
      //      new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
      //      new Enrollment{StudentID=6,CourseID=1045},
      //      new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
      //};
      //foreach (Enrollment e in enrollments)
      //{
      //  context.Enrollments.Add(e);
      //}
      //context.SaveChanges();
    }
  }
}
