using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.Entity;
using System.Linq;
using ProyectoFinal.Data.Modelo;
using ProyectoFinal.Data.Entidades;
using ManejoDB;

namespace RegistroUsuario
{
    public partial class RegistroUsuario : Form
    {
        ManipulacionDB MDB;
        int tu = 0;
        public RegistroUsuario()
        {
            InitializeComponent();
            Database.SetInitializer<FinalProyectDB>(new DropCreateDatabaseAlways<FinalProyectDB>());
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
            MDB = new ManipulacionDB();
            var user = new Usuarios( MDB.SearchUser(Convert.ToInt32(IdUsuario.Text)));
            IdUsuario.Text = user.Id.ToString();
            TBnombre.Text = user.Nombre;
            TBUsuario.Text = user.Usuario;
            TBConfPass.Text = TBPass.Text = user.Contraseña;
            TiposUsuario.SelectedItem = user.Tipo_Usuario;
        }

        private void cargarTipoUsuario()
        {
            MDB = new ManipulacionDB();
            TiposUsuario.DataSource = MDB.TypeUserList();
            TiposUsuario.ValueMember = "Id";
            TiposUsuario.DisplayMember = "Tipo_Usuario";
        }

        private void CrearCuenta_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(TBnombre.Text) && !string.IsNullOrEmpty(TBUsuario.Text) && !string.IsNullOrEmpty(TBPass.Text) && !string.IsNullOrEmpty(TBConfPass.Text))
            {
                if (!TBnombre.Text.Equals("Ejemplo: Juan Perez") && !TBUsuario.Text.Equals("Ejemplo: juan02") && !TBPass.Text.Equals("Contraseña") && !TBConfPass.Text.Equals("Contraseña"))
                {
                    if (TBPass.Text.Equals(TBConfPass.Text))
                    {
                        MDB = new ManipulacionDB();
                        MDB.AddUser(new Usuarios() { Id = Convert.ToInt32(IdUsuario.Text),
                            Nombre = TBnombre.Text,
                            Usuario = TBUsuario.Text,
                            Contraseña = TBPass.Text,
                            Tipo_Usuario = TiposUsuario.SelectedText
                        });
                        TBnombre.ForeColor = TBPass.ForeColor = TBConfPass.ForeColor = TBUsuario.ForeColor = Color.Silver;
                        TBnombre.Text = "Ejemplo: Juan Perez";
                        TBUsuario.Text = "Ejemplo: juan02";
                        TBPass.Text = "Contraseña";
                        TBConfPass.Text = "Contraseña";    
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
            MDB = new ManipulacionDB();
            MDB.DeleteUser(new Usuarios()
            {
                Id = Convert.ToInt32(IdUsuario.Text),
                Nombre = TBnombre.Text,
                Usuario = TBUsuario.Text,
                Contraseña = TBPass.Text,
                Tipo_Usuario = TiposUsuario.SelectedItem.ToString()
            });
            limpiarPantalla();
        }

        private void PBFondo_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var coneccion = new FinalProyectDB();
            coneccion.TypeUser.Add(new TipoDeUsuario() { Id = 1, Tipo_Usuario = "Administrador" });
            coneccion.TypeUser.Add(new TipoDeUsuario() { Id = 2, Tipo_Usuario = "Vendedor" });
            coneccion.TypeUser.Add(new TipoDeUsuario() { Id = 3, Tipo_Usuario = "Granjero" });
            coneccion.SaveChanges();
            if(tu == 0)
            {
                cargarTipoUsuario();
                ++tu;
            }
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
