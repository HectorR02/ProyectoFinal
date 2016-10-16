using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }

        public string Organización { get; set; }

        public string Representante { get; set; }

        public string Direccion { get; set; }

        public int Teléfono { get; set; }
    }
}
