using ProyectoFinal.Data.Entidades;
using System.Data.Entity;

namespace ProyectoFinal.Data.Modelo
{
    public class FinalProyectDB: DbContext
    {
        public DbSet<TipoDeUsuario> TypeUser { get; set; }
        public DbSet<Usuarios> User { get; set; }
        public DbSet<Empleado> Employe { get; set; }
    }
}
