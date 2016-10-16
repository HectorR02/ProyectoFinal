using System;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }

        public string Organización { get; set; }

        public string Representante { get; set; }

        public string Dirección { get; set; }

        public Int64 Teléfono { get; set; }
    }
}
