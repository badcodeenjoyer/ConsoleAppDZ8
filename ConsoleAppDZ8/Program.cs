using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Threading.Tasks;
using System.Linq;
using ConsoleAppDZ8.Models;
using System.Collections.Generic;

namespace ConsoleAppDZ8
{
    class Program
    {
        public static void Main(string[] args)
        {
            using (DZ8DbContext db = new())
            {

                //Admin admin1 = new() { AdminsRole = "Manadger", Name = "Petro", };
                //Admin admin2 = new() { AdminsRole = "SuperManadger", Name = "Stepan", };
                //User user1 = new() { Name = "Tom", Age = 33 , Admin = admin1};
                //User user2 = new() { Name = "Alice", Age = 26 , Admin = admin2 };
                //User user3 = new() { Name = "Jane", Age = 21 , Admin =  admin2 };
                User userforadding = new() { Name = "BillyCool" };

                //db.Users.Add(user1);
                //db.Users.Add(user2);
                //db.Users.Add(user3);
                //db.Admins.Add(admin1);
                //db.Admins.Add(admin2);
                
                Farmer farmer1 = new() { Name = "Betty" };
                Farmer farmer2 = new() { Name = "Vasylii" };
                db.Add(farmer1);
                db.Add(farmer2);
                Cow cow1 = new() { Name = "Moogy" };
                Cow cow2 = new() { Name = "Whity" };
                Cow cow3 = new() { Name = "Milky" };
                Cow cow4 = new() { Name = "Tiddy" };
                Cow cow5 = new() { Name = "Girfy" };
                farmer1.Cows.Add(cow1);
                farmer1.Cows.Add(cow5);
                farmer2.Cows.Add(cow2);
                farmer2.Cows.Add(cow3);
                farmer2.Cows.Add(cow4);
                db.SaveChanges();
                Cow cowtwo = db.Cows.Where(c => c.Name == "Whity").First();

                
                db.Cows.Remove(cow2);


                Farmer farmertwo = db.Farmers.Where(g => g.Name == "Vasylii").First();
                farmertwo.Name = "Vasya";
                foreach (Cow cow in db.Cows)
                {
                    Console.WriteLine(cow.Name);
                }
                db.Add(userforadding);
                db.SaveChanges();
            }
            Console.Read();
            
        }
    }
}
