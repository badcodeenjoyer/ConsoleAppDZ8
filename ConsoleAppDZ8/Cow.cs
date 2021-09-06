using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDZ8
{
   public  class Cow
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Farmer> Farmers { get; set; } = new List<Farmer>();
    }
}
