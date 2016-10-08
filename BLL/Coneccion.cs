using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class Coneccion
    {
        public Granja_Huevos con;
        public Coneccion()
        {
            con = new Granja_Huevos();
        }

        public string AgregarUsuario(Usuarios nuevo)
        {
            string resultado = "-- Operacion Fallida --";
            using (var conexion = new Granja_Huevos())
            {
                try
                {
                    conexion.Usuario.Add(nuevo);
                    conexion.SaveChanges();
                    resultado = "-- Operacion Exitosa -- ";
                }catch(Exception e)
                {
                    resultado =  e.ToString();
                }
            }
            return resultado;
        }
        



        public string AgregarTipo(TipoDeUsuarios nuevo)
        {
            string resultado = "-- Operacion Fallida --";
            using (var conexion = new Granja_Huevos())
            {
                try
                {
                    conexion.Tipo.Add(nuevo);
                    conexion.SaveChanges();
                    resultado = "-- Operacion Existosa --";
                }catch(Exception e)
                {
                    resultado += e.ToString();
                }
            }
            return resultado;
        }
        public List<TipoDeUsuarios> ListarTipos()
        {
            var tipos = new List<TipoDeUsuarios>();
            using (var conexion = new Granja_Huevos())
            {
                try
                {
                   // tipos =  conexion.Tipo.Include(x => x.Id);
                }catch(Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
            return tipos;
        }
    }
}
