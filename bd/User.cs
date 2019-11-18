using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bd
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Cgroup Cgroup { get; set; }
        public Oklad Oklad { get; set; }
        public Otpysk Otpysk { get; set; }
    }
}
