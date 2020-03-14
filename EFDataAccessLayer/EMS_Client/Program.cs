using System;
using EFDataAccessLayer;
using EFDataAccessLayer.models;
using EFDataAccessLayer.context;

namespace EMS_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //add new project
            using(Mycontext db=new Mycontext())
            {
                project p = new project() { pname = "tttt",sdate=new DateTime('11-2-2019') };
                db.Add(p);
                db.SaveChanges();
            }
            
        }
    }
}
