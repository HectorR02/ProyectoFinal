using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios
    {
        [Key]

        public string Nombre { get; set; }

        public string Usuario { get; set; }

        public string Contraseña { get; set; }
    }
}
