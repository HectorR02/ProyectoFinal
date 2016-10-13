using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Usuarios
    {
        [Key]

        public int UsuarioId { get; set; }

        public string Nombre { get; set; }

        public string Usuario { get; set; }

        public string Clave { get; set; }

        public string TipoDeUsuario { get; set; }
    }
}
