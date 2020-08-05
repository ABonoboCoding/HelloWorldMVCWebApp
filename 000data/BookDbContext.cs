using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace HelloWorldMVCWebApp._000data
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
        {
        }   

        public DbSet<Book> Books { get; set; }

        public DbSet<Computer> Computers { get; set; }
        //specifying singular table names
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //      modelBuilder.Entity<Book>().ToTable("Book"):
        //)

        /* Commands:
            dotnet tool install --global dotnet-ef 

            dotnet ef migrations add InitialCreate   -- creates script 

             

            dotnet ef database update  -- creates db and runs the migration 

             

            dotnet ef migrations remove 

            dotnet ef database drop 
         */

    }
}
