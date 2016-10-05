﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Entidades;
using BLL;

namespace RegistroUsuario
{
    public partial class RegistroUsuario : Form
    {
        string sql;
        public RegistroUsuario()
        {
            InitializeComponent();
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

        

        private void CrearCuenta_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(TBnombre.Text) && !string.IsNullOrEmpty(TBUsuario.Text) && !string.IsNullOrEmpty(TBPass.Text) && !string.IsNullOrEmpty(TBConfPass.Text))
            {
                if (!TBnombre.Text.Equals("Ejemplo: Juan Perez") && !TBUsuario.Text.Equals("Ejemplo: juan02") && !TBPass.Text.Equals("Contraseña") && !TBConfPass.Text.Equals("Contraseña"))
                {
                    if (TBPass.Text.Equals(TBConfPass.Text))
                    {
                        UsuariosBLL con = new UsuariosBLL();
                        sql = "INSERT INTO Usuario (Nombre,Usuario,Contraseña) values('" + TBnombre.Text + "','" + TBUsuario.Text + "','" + TBPass.Text + "')";
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
                    if (TBnombre.Text.Equals("Ejemplo: Juan Perez") || TBnombre.ForeColor == Color.Silver)
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
