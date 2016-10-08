using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Data.Entidades
{
    public class Usuarios
    {
        private Usuarios usuarios;

        public Usuarios(Usuarios usuarios)
        {
            this.usuarios = usuarios;
        }

        public Usuarios()
        {
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Tipo_Usuario { get; set; }
    }
}
