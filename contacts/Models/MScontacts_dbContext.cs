using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace contacts.Models
{
    public partial class MScontacts_dbContext : DbContext
    {
        // Unable to generate entity type for table 'dbo.Contact'. Please see the warning messages.

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer(@"Server=tcp:mscontactsdbserver.database.windows.net,1433;Initial Catalog=MScontacts_db;Persist Security Info=False;User ID=itsikr;Password=It5ikRafael;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
//            }
//        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{}
    }
}
