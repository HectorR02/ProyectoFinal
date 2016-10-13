using System;
using System.Drawing;
using System.Windows.Forms;
using Entidades;

namespace RegistroUsuario
{
    public partial class RegistroUsuario : Form
    {
        int tu = 0;
        public RegistroUsuario()
        {
            InitializeComponent();
           // Database.SetInitializer<FinalProyectDB>(new DropCreateDatabaseAlways<FinalProyectDB>());
            Utileria v = new Utileria(IdUsuarioTextBox, "Ejemplo: juan02", TBnombreTextBox,"N");
            Utileria v1 = new Utileria(TBnombreTextBox, "Ejemplo: Juan Perez", TBUsuarioTextBox,"L");
            Utileria v2 = new Utileria(TBUsuarioTextBox, "Ejemplo: juan02", TBPassTextBox,"LN"); 
            Utileria v3 = new Utileria(TBPassTextBox, "Ejemplo: juan02", TBConfPassTextBox, "Pass");
            Utileria v4 = new Utileria(TBConfPassTextBox, "Ejemplo: juan02", IdUsuarioTextBox, "Pass");
          // DeshabilitarBotones();
            Nombre.Parent = Usuario.Parent = Pass.Parent = ConfPass.Parent = Titulo.Parent = CBVerPass.Parent = label2.Parent = label1.Parent = PBFondo;
            Nombre.BackColor = Usuario.BackColor = Pass.BackColor = ConfPass.BackColor = Titulo.BackColor = CBVerPass.BackColor = label2.BackColor = label1.BackColor = Color.Transparent;
        }        

        public void DeshabilitarBotones()
        {
            TBConfPassTextBox.Enabled = TBUsuarioTextBox.Enabled = TBPassTextBox.Enabled = TBnombreTextBox.Enabled = TiposUsuarioComboBox.Enabled = Guardar.Enabled = Eliminar.Enabled = false;
        }

        public void HabilitarCampos()
        {
           TiposUsuarioComboBox.Enabled = TBUsuarioTextBox.Enabled = TBPassTextBox.Enabled = TBnombreTextBox.Enabled = TBConfPassTextBox.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CBVerPass.Checked)
            {
                if (TBConfPassTextBox.PasswordChar == '*' || TBPassTextBox.PasswordChar == '*')
                    TBPassTextBox.PasswordChar = TBConfPassTextBox.PasswordChar = '\0';
            }
            else
                TBPassTextBox.PasswordChar = TBConfPassTextBox.PasswordChar = '*';
        }

        private void cargarUsuario()
        {
            if (!IdUsuarioTextBox.Text.Equals("Ejemplo: 0001"))
            {
                
                var user = BLL.UsuariosBLL.Buscar(Convert.ToInt32(IdUsuarioTextBox.Text));
                if (user != null)
                {
                    TBnombreTextBox.ForeColor = TBPassTextBox.ForeColor = TBConfPassTextBox.ForeColor = TBUsuarioTextBox.ForeColor = Color.Black;
                    IdUsuarioTextBox.Text = user.UsuarioId.ToString();
                    IdUsuarioTextBox.Enabled = false;
                    TBnombreTextBox.Text = user.Nombre;
                    TBUsuarioTextBox.Text = user.Usuario;
                    TBConfPassTextBox.Text = TBPassTextBox.Text = user.Clave;
                    TiposUsuarioComboBox.SelectedIndex = Convert.ToInt32(user.TipoDeUsuario)-1;
                    HabilitarCampos();
                    Eliminar.Enabled = Guardar.Enabled = true;
                }
                else
                    MessageBox.Show("No se encontro el usuario que busca");
            }else
            {
                var error = new ErrorProvider(this);
            }            
        }

        private void cargarTipoUsuario()
        {
            TiposUsuarioComboBox.DataSource = BLL.TiposDeUsuarioBLL.GetLista();
            TiposUsuarioComboBox.ValueMember = "TipoDeUsuarioId";
            TiposUsuarioComboBox.DisplayMember = "TipoDeUsuario";
        }

        private void CrearCuenta_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(TBnombreTextBox.Text) && !string.IsNullOrEmpty(TBUsuarioTextBox.Text) && !string.IsNullOrEmpty(TBPassTextBox.Text) && !string.IsNullOrEmpty(TBConfPassTextBox.Text))
            {
                if (!TBnombreTextBox.Text.Equals("Ejemplo: Juan Perez") && !TBUsuarioTextBox.Text.Equals("Ejemplo: juan02") && !TBPassTextBox.Text.Equals("Contraseña") && !TBConfPassTextBox.Text.Equals("Contraseña"))
                {
                    if (TBPassTextBox.Text.Equals(TBConfPassTextBox.Text))
                    {
                        BLL.UsuariosBLL.Insertar(new Usuarios() { UsuarioId = Convert.ToInt32(IdUsuarioTextBox.Text),
                            Nombre = TBnombreTextBox.Text,
                            Usuario = TBUsuarioTextBox.Text,
                            Clave = TBPassTextBox.Text,
                            TipoDeUsuario = TiposUsuarioComboBox.SelectedValue.ToString()
                        });
                        limpiarPantalla();
                        DeshabilitarBotones();
                        TiposUsuarioComboBox.SelectedIndex = 0;
                    }
                    else
                    {
                        TBPassTextBox.Text = TBConfPassTextBox.Text = "Contraseña";
                        TBPassTextBox.ForeColor = TBConfPassTextBox.ForeColor = Color.Silver;
                        if (TBConfPassTextBox.PasswordChar == '*')
                            TBPassTextBox.PasswordChar = TBConfPassTextBox.PasswordChar = '\0';
                        TBPassTextBox.Focus();
                        MessageBox.Show("Las contraseñas no son iguales\n\"Vuelve a Repetirlas\"");
                    }
                }
                else
                if (IdUsuarioTextBox.Text.Equals("Ejemplo: 0001"))
                    IdUsuarioTextBox.Focus();
                else if(TBnombreTextBox.Text.Equals("Ejemplo: Juan Perez") || TBnombreTextBox.ForeColor == Color.Silver)
                        TBnombreTextBox.Focus();
                      else if (TBUsuarioTextBox.Text.Equals("Ejemplo: juan02"))
                              TBUsuarioTextBox.Focus();
                           else if (TBPassTextBox.Text.Equals("Contraseña"))
                                    TBPassTextBox.Focus();
                                else if (TBConfPassTextBox.Text.Equals("Contraseña")) 
                                        TBConfPassTextBox.Focus();
                                  
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BLL.UsuariosBLL.Eliminar(new Usuarios()
            {
                UsuarioId = Convert.ToInt32(IdUsuarioTextBox.Text),
                Nombre = TBnombreTextBox.Text,
                Usuario = TBUsuarioTextBox.Text,
                Clave = TBPassTextBox.Text,
                TipoDeUsuario = TiposUsuarioComboBox.SelectedItem.ToString()
            });
            limpiarPantalla();
        }

        private void PBFondo_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if(tu == 0)
            {
                BLL.TiposDeUsuarioBLL.Insertar(new TiposDeUsuario() { TipoDeUsuarioID = 1, TipoDeUsuario = "Administrador" });
                BLL.TiposDeUsuarioBLL.Insertar(new TiposDeUsuario() { TipoDeUsuarioID = 2, TipoDeUsuario = "Vendedor" });
                BLL.TiposDeUsuarioBLL.Insertar(new TiposDeUsuario() { TipoDeUsuarioID = 3, TipoDeUsuario = "Granjero" });
                cargarTipoUsuario();
                ++tu;
            }
            limpiarPantalla();
        }

        private void limpiarPantalla()
        {
            IdUsuarioTextBox.ForeColor = TBnombreTextBox.ForeColor = TBPassTextBox.ForeColor = TBConfPassTextBox.ForeColor = TBUsuarioTextBox.ForeColor = Color.Silver;
            IdUsuarioTextBox.Text = "Ejemplo: 0001";
            TBnombreTextBox.Text = "Ejemplo: Juan Perez";
            TBUsuarioTextBox.Text = "Ejemplo: juan02";
            TBPassTextBox.Text = "Contraseña";
            TBConfPassTextBox.Text = "Contraseña";
            if (!TBnombreTextBox.Enabled)
                TBnombreTextBox.Enabled = TBUsuarioTextBox.Enabled = TBPassTextBox.Enabled = TBConfPassTextBox.Enabled = Guardar.Enabled = Eliminar.Enabled = CBVerPass.Enabled = TiposUsuarioComboBox.Enabled = true;
            if (TBPassTextBox.PasswordChar == '*')
                TBPassTextBox.PasswordChar = TBConfPassTextBox.PasswordChar = '\0';
            IdUsuarioTextBox.Focus();
        }

        private void IdUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {            
            cargarUsuario();
        }
    }
}
