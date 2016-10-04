using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DALL;
using System.Data.SqlClient;

namespace BLL
{
    public  class UsuariosBLL
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        public UsuariosBLL()
        {
            try
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=Prueba;Integrated Security=True");
                cn.Open();
            }
            catch (Exception ex)
            {

            }
        }
        public string insertar(String sql)
        {
            string resultado = "Proceso finalizado satisfactoriamente";
            try
            {
                cmd = new SqlCommand(sql, cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                resultado = "No se pudo procesar: " + ex.ToString();
            }
            return resultado;
        }
    }
}
