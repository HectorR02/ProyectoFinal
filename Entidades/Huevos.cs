using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Huevos
    {
        [Key]
        public int HuevosId { get; set; }

        public string TipoDeHuevo { get; set; }
    }
}
