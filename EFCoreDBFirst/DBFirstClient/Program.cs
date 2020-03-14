using System;
using Microsoft.EntityFrameworkCore;
using EFCoreDBFirst.Models;



namespace DBFirstClient
{
    class Program:DbContext
    {
        static void Main(string[] args)
        {
           using(practiceDbContext db=new practiceDbContext())
            {
                School sh = new School() { Sname = "ZP", Strength = 10 };
                db.Add(sh);
                db.SaveChanges();

            }
        }
    }
}
