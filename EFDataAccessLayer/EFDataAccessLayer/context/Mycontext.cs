using System;
using System.Collections.Generic;
using System.Text;
using EFDataAccessLayer.models;
using Microsoft.EntityFrameworkCore;

namespace EFDataAccessLayer.context
{
    public class Mycontext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-80R3HO1\SQLEXPRESS;Initial Catalog=ProjectDB;User ID=sa;Password=pass@word1");
        }
        public DbSet<project> Projects { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
