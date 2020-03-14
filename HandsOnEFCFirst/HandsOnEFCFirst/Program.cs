using System;
using HandsOnEFCFirst.Models;
using HandsOnEFCFirst.context;
using System.Linq;
using System.Collections.Generic;

namespace HandsOnEFCFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using(Mycontext db=new Mycontext())
            {
                //insert new record
                //Student s = new Student() { name = "raj", age = 12, std = "IV" };
                //db.Student.Add(s);
                //db.SaveChanges();
                //fetch record
                //Student s = db.Student.Find(1);//return single record using primary key
                //Console.WriteLine("welcome{0}", s.name);
                //fetch one record using nonprimary key
                //Student s1 = db.Student.SingleOrDefault(i => i.name == "raj");//for single( non primary key)
             /*   List<Student> list = db.Student.Where(i => i.age == 10).ToList();*///for multiple values(non primary key)
                                                                                 //List<Student> list1 = db.Student.Where(i => i.age == 10 && i.std == "II").ToList();

                ////update record
                //Student s2 = db.Student.Find(1);
                //s2.age = 11;
                //db.Student.Update(s2);
                //db.SaveChanges();

                //delete record
                List<Student> list = db.Student.Where(i => i.name== "raj").ToList();
                foreach (var stu in list)
                {
                    db.Student.Remove(stu);

                    db.SaveChanges();
                }
            }
        }
    }
}
