using Conexion1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroUsuario
{
    public partial class RegistroUsuario : Form
    {
        string sql;
        public RegistroUsuario()
        {
            InitializeComponent();
            Nombre.Parent = Usuario.Parent = Pass.Parent = ConfPass.Parent = Titulo.Parent = CBVerPass.Parent = PBFondo;
            Nombre.BackColor = Usuario.BackColor = Pass.BackColor = ConfPass.BackColor = Titulo.BackColor = CBVerPass.BackColor = Color.Transparent;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrEmpty(TBUsuario.Text))
                {
                    TBUsuario.Text = "Ejemplo: juan02";
                    TBUsuario.ForeColor = Color.Silver;
                }
                TBPass.Focus();
            }
            else
                if (Char.IsDigit(e.KeyChar) || Char.IsLetter(e.KeyChar))
                if (TBUsuario.Text.Equals("Ejemplo: juan02"))
                {
                    TBUsuario.Clear();
                    TBUsuario.ForeColor = Color.Black;
                }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrEmpty(TBPass.Text))
                {
                    TBPass.Text = "Contraseña";
                    TBPass.ForeColor = Color.Silver;
                    if (TBPass.PasswordChar == '*')
                        TBPass.PasswordChar = '\0';
                }
                TBConfPass.Focus();
            }
            else
                if (Char.IsDigit(e.KeyChar) || Char.IsLetter(e.KeyChar))
                if (TBPass.Text.Equals("Contraseña"))
                {
                    TBPass.Clear();
                    TBPass.PasswordChar = '*';
                    TBPass.ForeColor = Color.Black;
                }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrEmpty(TBConfPass.Text))
                {
                    TBConfPass.Text = "Contraseña";
                    TBConfPass.ForeColor = Color.Silver;
                    if (TBConfPass.PasswordChar == '*')
                        TBConfPass.PasswordChar = '\0';
                }
                TBConfPass.Focus();
            }
            else
                if (Char.IsDigit(e.KeyChar) || Char.IsLetter(e.KeyChar))
                if (TBConfPass.Text.Equals("Contraseña"))
                {
                    TBConfPass.Clear();
                    TBConfPass.PasswordChar = '*';
                    TBConfPass.ForeColor = Color.Black;
                }
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

        private void TBnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrEmpty(TBnombre.Text))
                {
                    TBnombre.Text = "Ejemplo: Juan Perez";
                    TBnombre.ForeColor = Color.Silver;
                }
                TBUsuario.Focus();
            }
            else
                if (Char.IsDigit(e.KeyChar) || Char.IsLetter(e.KeyChar))
                if (TBnombre.Text.Equals("Ejemplo: Juan Perez"))
                {
                    TBnombre.Clear();
                    TBnombre.ForeColor = Color.Black;
                }
        }

        private void CrearCuenta_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(TBnombre.Text) && !string.IsNullOrEmpty(TBUsuario.Text) && !string.IsNullOrEmpty(TBPass.Text) && !string.IsNullOrEmpty(TBConfPass.Text))
            {
                if (!TBnombre.Text.Equals("Ejemplo: Juan Perez") && !TBUsuario.Text.Equals("Ejemplo: juan02") && !TBPass.Text.Equals("Contraseña") && !TBConfPass.Text.Equals("Contraseña"))
                {
                    if (TBPass.Text.Equals(TBConfPass.Text))
                    {
                        Conexion con = new Conexion();
                        sql = "INSERT INTO Usuario (Nombre,Usuario,Contraseña) values('" + TBnombre.Text + "','" + TBUsuario.Text + "','" + TBPass.Text + "')";
                        MessageBox.Show(con.insertar(sql));
                        TBnombre.Text = "Ejemplo: Juan Perez";
                        TBUsuario.Text = "Ejemplo: juan02";
                        TBPass.Text = "Contraseña";
                        TBConfPass.Text = "Contraseña";
                        TBnombre.ForeColor = TBPass.ForeColor = TBConfPass.ForeColor = TBUsuario.ForeColor = Color.Silver;
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
                    if (TBnombre.Text.Equals("Ejemplo: Juan Perez"))
                        TBnombre.Focus();
                    else if (TBUsuario.Text.Equals("Ejemplo: juan02"))
                            TBUsuario.Focus();
                        else if (TBPass.Text.Equals("Contraseña"))
                                TBPass.Focus();
                            else if (TBConfPass.Text.Equals("Contraseña"))
                                    TBConfPass.Focus();
            }
            
        }
    }
}
