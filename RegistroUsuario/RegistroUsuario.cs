using System;
using System.Drawing;
using System.Windows.Forms;
using Entidades;
using BLL;
using System.Data.SqlClient;

namespace RegistroUsuario
{
    public partial class RegistroUsuario : Form
    {
        string sql;
        UsuariosBLL con;
        public RegistroUsuario()
        {
            InitializeComponent();
            cargarTipoUsuario();
            Utileria v = new Utileria(IdUsuario, "Ejemplo: juan02", TBnombre,"N");
            Utileria v1 = new Utileria(TBnombre, "Ejemplo: Juan Perez", TBUsuario,"L");
            Utileria v2 = new Utileria(TBUsuario, "Ejemplo: juan02", TBPass,"LN"); 
            Utileria v3 = new Utileria(TBPass, "Ejemplo: juan02", TBConfPass, "Pass");
            Utileria v4 = new Utileria(TBConfPass, "Ejemplo: juan02", IdUsuario, "Pass");

            Nombre.Parent = Usuario.Parent = Pass.Parent = ConfPass.Parent = Titulo.Parent = CBVerPass.Parent = label2.Parent = label1.Parent = PBFondo;
            Nombre.BackColor = Usuario.BackColor = Pass.BackColor = ConfPass.BackColor = Titulo.BackColor = CBVerPass.BackColor = label2.BackColor = label1.BackColor = Color.Transparent;
        }        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CBVerPass.Checked)
            {
                if (TBConfPass.PasswordChar == '*' || TBPass.PasswordChar == '*')
                    TBPass.PasswordChar = TBConfPass.PasswordChar = '\0';
            }
            else
                TBPass.PasswordChar = TBConfPass.PasswordChar = '*';
        }

        private void cargarUsuario()
        {
            con = new UsuariosBLL();
            string SQL = "SELECT Id, Nombre, Usuario, Contraseña, Tipo_Usuario FROM Usuarios WHERE Id = "+ IdUsuario.Text;
            SqlDataReader usuario = con.consultar(SQL);
            if (usuario.Read())
            {
                limpiarPantalla();
                IdUsuario.ForeColor = TBnombre.ForeColor = TBPass.ForeColor = TBConfPass.ForeColor = TBUsuario.ForeColor = Color.Black;
                TBPass.PasswordChar = TBConfPass.PasswordChar = '*';


                IdUsuario.Text = usuario.GetInt32(0).ToString();
                TBnombre.Text = usuario.GetString(1);
                TBUsuario.Text = usuario.GetString(2);
                TBPass.Text = TBConfPass.Text = usuario.GetString(3);
                TiposUsuario.SelectedItem = usuario.GetString(4);

                con.cn.Close();
            }
            else
                MessageBox.Show("-- Busqueda Fallida --\nNo se encontro el usuario");
        }

        private void cargarTipoUsuario()
        {
            string SQL = "SELECT Tipo_Usuario FROM TipoDeUsuario";
            con = new UsuariosBLL();
            SqlDataReader tipoUsuario = con.consultar(SQL);
            TiposUsuario.Items.Add("Tipos de Usuario...");
            while (tipoUsuario.Read())
            {
                TiposUsuario.Items.Add(tipoUsuario.GetString(0));
            }
            TiposUsuario.SelectedItem = "Tipos de Usuario...";
        }

        private void CrearCuenta_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(TBnombre.Text) && !string.IsNullOrEmpty(TBUsuario.Text) && !string.IsNullOrEmpty(TBPass.Text) && !string.IsNullOrEmpty(TBConfPass.Text))
            {
                if (!TBnombre.Text.Equals("Ejemplo: Juan Perez") && !TBUsuario.Text.Equals("Ejemplo: juan02") && !TBPass.Text.Equals("Contraseña") && !TBConfPass.Text.Equals("Contraseña"))
                {
                    if (TBPass.Text.Equals(TBConfPass.Text))
                    {
                        UsuariosBLL con = new UsuariosBLL();
                        sql = "INSERT INTO Usuarios (Nombre,Usuario,Contraseña,Tipo_Usuario) values('" + TBnombre.Text + "','" + TBUsuario.Text + "','" + TBPass.Text + "','Administrador')";
                        TBnombre.ForeColor = TBPass.ForeColor = TBConfPass.ForeColor = TBUsuario.ForeColor = Color.Silver;
                        TBnombre.Text = "Ejemplo: Juan Perez";
                        TBUsuario.Text = "Ejemplo: juan02";
                        TBPass.Text = "Contraseña";
                        TBConfPass.Text = "Contraseña";                        
                        MessageBox.Show(con.insertar(sql));
                    }
                    else
                    {
                        TBPass.Text = TBConfPass.Text = "Contraseña";
                        TBPass.ForeColor = TBConfPass.ForeColor = Color.Silver;
                        if (TBConfPass.PasswordChar == '*')
                            TBPass.PasswordChar = TBConfPass.PasswordChar = '\0';
                        TBPass.Focus();
                        MessageBox.Show("Las contraseñas no son iguales\n\"Vuelve a Repetirlas\"");
                    }
                }
                else
                if (IdUsuario.Text.Equals("Ejemplo: 0001"))
                    IdUsuario.Focus();
                else if(TBnombre.Text.Equals("Ejemplo: Juan Perez") || TBnombre.ForeColor == Color.Silver)
                        TBnombre.Focus();
                      else if (TBUsuario.Text.Equals("Ejemplo: juan02"))
                              TBUsuario.Focus();
                           else if (TBPass.Text.Equals("Contraseña"))
                                    TBPass.Focus();
                                else if (TBConfPass.Text.Equals("Contraseña")) 
                                        TBConfPass.Focus();
                                  
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con = new UsuariosBLL();
            string SQL = "DELETE FROM Usuarios WHERE Id =" + IdUsuario.Text;
            MessageBox.Show(con.insertar(SQL));
            limpiarPantalla();
        }

        private void PBFondo_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            limpiarPantalla();
        }

        private void limpiarPantalla()
        {
            IdUsuario.ForeColor = TBnombre.ForeColor = TBPass.ForeColor = TBConfPass.ForeColor = TBUsuario.ForeColor = Color.Silver;
            IdUsuario.Text = "Ejemplo: 0001";
            TBnombre.Text = "Ejemplo: Juan Perez";
            TBUsuario.Text = "Ejemplo: juan02";
            TBPass.Text = "Contraseña";
            TBConfPass.Text = "Contraseña";
            if (!TBnombre.Enabled)
                TBnombre.Enabled = TBUsuario.Enabled = TBPass.Enabled = TBConfPass.Enabled = Guardar.Enabled = Eliminar.Enabled = CBVerPass.Enabled = TiposUsuario.Enabled = true;
            if (TBPass.PasswordChar == '*')
                TBPass.PasswordChar = TBConfPass.PasswordChar = '\0';
            IdUsuario.Focus();
        }

        private void IdUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {            
            cargarUsuario();
            Guardar.Enabled = false;
        }
    }
}
