using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bd
{
    public class Oklad
    {
        public int Id { get; set; }

        public int Oklad1 { get; set; }
        public ICollection<User> Users { get; set; }
        public Oklad()
        {
            Users = new List<User>();
        }
    }
}
