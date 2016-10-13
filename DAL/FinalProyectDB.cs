using Entidades;
using System.Data.Entity;

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
