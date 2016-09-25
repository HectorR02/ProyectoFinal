using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            label1.Parent = PBFondoLogin;
            label1.BackColor = Color.Transparent;
            CBMostrarContraseña.Parent = PBFondoLogin;
            CBMostrarContraseña.BackColor = Color.Transparent;            
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrEmpty(textBox1.Text.Trim()))
                {
                    textBox1.Text = "Usuario";
                    textBox1.ForeColor = Color.Silver;
                }
                
                textBox2.Focus();
            }
            else
                if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar))
                {
                    if(textBox1.Text.Equals("Usuario"))
                    {
                        textBox1.Clear();
                        textBox1.ForeColor = Color.Black;
                    }
                }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if(string.IsNullOrEmpty(textBox2.Text.Trim()))
                {
                    textBox2.PasswordChar = '\0';
                    textBox2.Text = "Contraseña";
                    textBox2.ForeColor = Color.Silver;
                }
            }
            else
                if(char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar))
                {
                    if (textBox2.Text.Equals("Contraseña"))
                    {
                        textBox2.Clear();
                        textBox2.PasswordChar = '*';
                        textBox2.ForeColor = Color.Black;
                    }
                }
        }

        private void CBMostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if(CBMostrarContraseña.Checked)
            {
                if (textBox2.PasswordChar == '*')
                    textBox2.PasswordChar = '\0';
            }
            else
                textBox2.PasswordChar = '*';
        }

        private void BIniciarSesion_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
        }
    }
}
