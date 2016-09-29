using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DALL
{
    public class UsersDB : DbContext
    {
        public UsersDB() : base("name = ConStr")
        {

        }
        public virtual DbSet<Usuarios> Usuario { get; set; }
    }
}
