using System.Data.Entity;
using Entidades;

namespace DAL
{
    public class Granja_Huevos: DbContext
    {
        public Granja_Huevos()
        {

        }
        public DbSet<Usuarios> Usuario { get; set; }
        public DbSet<TipoDeUsuarios> Tipo { get; set; }
    }
}
