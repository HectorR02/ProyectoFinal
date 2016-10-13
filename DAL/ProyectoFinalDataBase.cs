using Entidades;
using System.Data.Entity;

namespace DAL
{
    public class ProyectoFinalDataBase : DbContext
    {
        public ProyectoFinalDataBase() :base("name=ConStr")
        {
       
        }
        public virtual DbSet<Usuarios> Usuario { get; set; }

        public virtual DbSet<TiposDeUsuario> TipoDeUsuario { get; set; }

        public virtual DbSet<Huevos> Huevo { get; set; }
    }
}
