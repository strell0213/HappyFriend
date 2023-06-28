using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmilDiplom
{
    internal class AC : DbContext
    {
        public DbSet<New> News { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Donate> Donates { get; set; }
        public AC() : base("DefaultConnection") { }
    }
}
