using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FinalProyectDB: DbContext 
    {
        public FinalProyectDB() : base ("name = ProFnal")
        {

        }
        public virtual DbSet<Usuarios> Users { get; set; }
        public virtual DbSet<TiposDeUsuario> TypeUsers { get; set; }
    }
}
