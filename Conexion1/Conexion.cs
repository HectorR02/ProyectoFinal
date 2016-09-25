using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Conexion1
{
    public class Conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        public Conexion()
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
                cmd = new SqlCommand(sql,cn);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                resultado = "No se pudo procesar: " + ex.ToString();
            }
            return resultado;
        }
    }
}
