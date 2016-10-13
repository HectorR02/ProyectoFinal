using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class TiposDeUsuario
    {
        [Key]

        public int TipoDeUsuarioID { get; set; }

        public string TipoDeUsuario { get; set; }
    }
}
