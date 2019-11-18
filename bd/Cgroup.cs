using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bd
{
    public class Cgroup
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<User> Users { get; set; }
        public Cgroup()
        {
            Users = new List<User>();
        }
    }
}
