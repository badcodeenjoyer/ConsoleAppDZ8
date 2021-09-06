using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppDZ8.Models
{
   public class DZ8DbContext :DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Cow> Cows { get; set; }
        public DbSet<Farmer> Farmers { get; set; }
        public DZ8DbContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();


        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Testing;Integrated Security=True");
        }

    }
}
