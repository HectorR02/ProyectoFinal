using System;
using System.Drawing;
using System.Windows.Forms;

namespace RegistroUsuario.Formularios
{

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //Temporal
            BLL.UsuariosBLL.Insertar(new Entidades.Usuarios() { UsuarioId = 1, Nombre = "Juan", Usuario = "Asource", Clave = "96321", TipoDeUsuario = "Administrador"});
            BLL.UsuariosBLL.Insertar(new Entidades.Usuarios() { UsuarioId = 2, Nombre = "Juan", Usuario = "juan02", Clave = "12369", TipoDeUsuario = "Vendedor" });
            //label1.Parent = PBFondoLogin;
            label1.BackColor = Color.Transparent;
            //CBMostrarContraseña.Parent = PBFondoLogin;
            CBMostrarContraseña.BackColor = Color.Transparent;            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrEmpty(UsuarioTextBox.Text.Trim()))
                {
                    UsuarioTextBox.Text = "Usuario";
                    UsuarioTextBox.ForeColor = Color.Silver;
                }
                
                ContraseñaTextBox.Focus();
            }
            else
                if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar))
                {
                    if(UsuarioTextBox.Text.Equals("Usuario"))
                    {
                        UsuarioTextBox.Clear();
                        UsuarioTextBox.ForeColor = Color.Black;
                    }
                }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if(string.IsNullOrEmpty(ContraseñaTextBox.Text.Trim()))
                {
                    ContraseñaTextBox.PasswordChar = '\0';
                    ContraseñaTextBox.Text = "Contraseña";
                    ContraseñaTextBox.ForeColor = Color.Silver;
                }
            }
            else
                if(char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar))
                {
                    if (ContraseñaTextBox.Text.Equals("Contraseña"))
                    {
                        ContraseñaTextBox.Clear();
                        ContraseñaTextBox.PasswordChar = '*';
                        ContraseñaTextBox.ForeColor = Color.Black;
                    }
                }
        }

        private void CBMostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if(CBMostrarContraseña.Checked)
            {
                if (ContraseñaTextBox.PasswordChar == '*')
                    ContraseñaTextBox.PasswordChar = '\0';
            }
            else
                ContraseñaTextBox.PasswordChar = '*';
        }

        private void BIniciarSesion_Click(object sender, EventArgs e)
        {
            var usuario = BLL.UsuariosBLL.Buscar(UsuarioTextBox.Text);
            if(usuario != null)
            {
                if (usuario.Clave.Equals(ContraseñaTextBox.Text))
                {
                    UsuarioTextBox.Text = "Usuario";
                    ContraseñaTextBox.PasswordChar = '\0';
                    ContraseñaTextBox.Text = "Contraseña";
                    UsuarioTextBox.ForeColor = ContraseñaTextBox.ForeColor = Color.Silver;
                    //Dispose();
                    //Close();
                    Hide();
                    var inicio = new Inicio(this);
                    inicio.ShowDialog();

                    //MessageBox.Show("Se conecto hehehe");
                }
                else
                {
                    MessageBox.Show(this,"La contraseña es invalida","-- Error --");
                    ContraseñaTextBox.Clear();
                    ContraseñaTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Este Usuario no existe en \nla base de datos","-- Busqueda Fallida --");
                UsuarioTextBox.Clear();
                ContraseñaTextBox.Clear();
                UsuarioTextBox.Text = "Usuario";
                ContraseñaTextBox.PasswordChar = '\0';
                ContraseñaTextBox.Text = "Contraseña";
                ContraseñaTextBox.ForeColor = UsuarioTextBox.ForeColor = Color.Silver;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }
    }
}
