using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDZ8
{
    public class Admin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AdminsRole { get; set; }
      //  public int UserId { get; set; }
     //   public User User { get; set; }
        public List<User> Users { get; set; } = new List<User>();
    }
}
