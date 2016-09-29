using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DALL;

namespace BLL
{
    public  class UsuariosBLL
    {
        public static bool Insertar(Usuarios usuario)
        {
            bool retorno = false;
            try
            {
                UsersDB db = new UsersDB();
                db.Usuario.Add(usuario);
                db.SaveChanges();
                retorno = true;
            }
            catch(Exception ex) { throw; }

            return retorno;
        }
    }
}
