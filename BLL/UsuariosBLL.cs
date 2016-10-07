using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DALL;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BLL
{
    public  class UsuariosBLL
    {
        public SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        public UsuariosBLL()
        {
            try
            {
                cn = new SqlConnection("Data source= HECTOR\\SQLEXPRESS;Initial Catalog=Granja_Huevos; User Id=sa; Password=20305952");
                //cn = new SqlConnection(@"Data source=.;Initial Catalog=Granja_Huevos; Integrated security=true;");
                cn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
        public SqlDataReader consultar(String sql)
        {
            cmd = new SqlCommand(sql,cn);
            dr = cmd.ExecuteReader();
            //cn.Close();
            return dr;
        }
    }
}
