using System;
using System.Collections.Generic;
using System.Text;
using HandsOnEFCFirst.Models;
using Microsoft.EntityFrameworkCore;//to use dbcontext

namespace HandsOnEFCFirst.context
{
    class Mycontext:DbContext
    {
      //define entities
      public DbSet<Student> Student { get; set; }
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-80R3HO1\SQLEXPRESS;Initial Catalog=StudentDb;User ID=sa;Password=pass@word1");
        }
    }
}
