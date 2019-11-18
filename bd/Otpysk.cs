using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bd
{
    public class Otpysk
    {
        public int Id { get; set; }
        public int kolvo_dney { get; set; }
        public ICollection<User> Users { get; set; }
        public Otpysk()
        {
            Users = new List<User>();
        }
    }
}
