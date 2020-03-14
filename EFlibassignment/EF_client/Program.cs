using System;
using EFlibassignment.models;
using EFlibassignment.context;

namespace EF_client
{
    class Program
    {
        static void Main(string[] args)
        {
           using(Mycontext db=new Mycontext())
            {
                //Item it = new Item() { itemName = "steve" };
                //db.Add(it);
                //db.SaveChanges();
                Order o = new Order() {itemId=2, orderdate = new DateTime(2019, 11, 2), deliverydate = DateTime.Parse("11-11-2019") };
                db.Add(o);
                db.SaveChanges();
            }
        }
    }
}
