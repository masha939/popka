using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Collections.Generic;

namespace bd
{
    class UserContext :DbContext
    {
        public UserContext()
              : base("DBConnection")
       { }
       public DbSet<User> Users { get; set; }
        public DbSet<Cgroup> Cgroups { get; set; }
        public DbSet<Oklad> Oklads { get; set; }
        public DbSet<Otpysk> Otpysks { get; set; }
    }
}
