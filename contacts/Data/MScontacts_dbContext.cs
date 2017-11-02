using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using contacts.Models;

namespace contacts.Data
{
  public class MScontacts_DbContext : DbContext
  {
    public DbSet<Contact> Contacts { get; set; }
   

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MyDatabase;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Contact>().ToTable("Contact");
    }

  }
}


  //public class Blog
  //{
  //  public int BlogId { get; set; }
  //  public string Url { get; set; }
  //  public int Rating { get; set; }
  //  public List<Post> Posts { get; set; }
  //}

  //public class Post
  //{
  //  public int PostId { get; set; }
  //  public string Title { get; set; }
  //  public string Content { get; set; }

  //  public int BlogId { get; set; }
  //  public Blog Blog { get; set; }
  //}
















//using System;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata;

//namespace contacts.Models
//{
//    public partial class MScontacts_dbContext : DbContext
//    {
//        // Unable to generate entity type for table 'dbo.Contact'. Please see the warning messages.

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer(@"Server=tcp:mscontactsdbserver.database.windows.net,1433;Initial Catalog=MScontacts_db;Persist Security Info=False;User ID=itsikr;Password=It5ikRafael;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
//            }
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {}
//    }
//}
