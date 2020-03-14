using System;
using System.Collections.Generic;
using System.Text;
using EFlibassignment.models;
using Microsoft.EntityFrameworkCore;

namespace EFlibassignment.context
{
    public class Mycontext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-80R3HO1\SQLEXPRESS;Initial Catalog=practiceDb;User ID=sa;Password=pass@word1");
        }
        public DbSet<Item> items { get; set; }
        public DbSet<Order> orders { get; set; }
    }
}
