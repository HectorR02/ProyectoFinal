using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RegistroUsuario.Registros
{
    public partial class RegistroCliente : Form
    {
        public RegistroCliente()
        {
            InitializeComponent();
            BLL.ClientesBLL.Insertar(new Clientes() { ClienteId = 1, Dirección = "La yaguisa", Organización = "biocacao", Representante = "Ramon Torres", Teléfono = 8095874612 });
            BLL.ClientesBLL.Insertar(new Clientes() { ClienteId = 2, Dirección = "La yaguisa", Organización = "biocacao", Representante = "Peralta", Teléfono = 8095874612 });
            BLL.ClientesBLL.Insertar(new Clientes() { ClienteId = 3, Dirección = "La yaguisa", Organización = "biocacao", Representante = "Ramon", Teléfono = 8095874612 });
            var val = new Utileria(ClienteIdTextBox, "Ejemplo: 0001", OrganizacionTextBox, "N");
            var val1 = new Utileria(OrganizacionTextBox, "Ejemplo: SuperMarket Pa' Comer", RepresentanteTextBox, "LN");
            var val2 = new Utileria(RepresentanteTextBox, "Ejemplo: Juan Pérez", DireccionTextBox, "L");
            var val3 = new Utileria(DireccionTextBox, "Ejemplo: Juan Pérez", TelefonoMaskedTextBox, "LN");
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelefonoMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                OrganizacionTextBox.Focus();
            }
            else
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                if (!TelefonoMaskedTextBox.MaskFull || TelefonoMaskedTextBox.ForeColor == Color.Silver)
                {
                    //TelefonoMaskedTextBox.Clear();
                    TelefonoMaskedTextBox.ForeColor = Color.Black;
                }
            }
            else
                e.Handled = true;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            var proximoCliente = BLL.ClientesBLL.UltimoCliente()+1;
            ClienteIdTextBox.Text = proximoCliente.ToString();
            BuscarButton.Enabled = ClienteIdTextBox.Enabled = false;            
            OrganizacionTextBox.Enabled = RepresentanteTextBox.Enabled = DireccionTextBox.Enabled = TelefonoMaskedTextBox.Enabled = GuardarButton.Enabled = EliminarButton.Enabled = true;
            OrganizacionTextBox.Focus();
        }

        public void Reiniciar()
        {
            ClienteIdTextBox.Enabled = BuscarButton.Enabled = true;
            ClienteIdTextBox.Text = "Ejemplo: 0001";
            OrganizacionTextBox.Text = "Ejemplo: SuperMarket Pa' Comer";
            RepresentanteTextBox.Text = "Ejemplo: Juan Pérez";
            DireccionTextBox.Text = "Ejemplo: Los Ríos #30, Sto. Dgo.";
            TelefonoMaskedTextBox.Clear();
            OrganizacionTextBox.Enabled = RepresentanteTextBox.Enabled = DireccionTextBox.Enabled = TelefonoMaskedTextBox.Enabled = GuardarButton.Enabled = EliminarButton.Enabled = false;
            ClienteIdTextBox.ForeColor = OrganizacionTextBox.ForeColor = RepresentanteTextBox.ForeColor = DireccionTextBox.ForeColor = TelefonoMaskedTextBox.ForeColor = System.Drawing.Color.Silver;
            ClienteIdTextBox.Focus();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (!OrganizacionTextBox.Text.Equals("Ejemplo: SuperMarket Pa' Comer"))
            {
                if (!RepresentanteTextBox.Text.Equals("Ejemplo: Juan Pérez"))
                {
                    if(!DireccionTextBox.Text.Equals("Ejemplo: Los Ríos #30, Sto. Dgo."))
                    {
                        if (TelefonoMaskedTextBox.MaskFull)
                        {
                            var telf = TelefonoMaskedTextBox.Text.Split('(', ')', ' ', '-');
                            string Tel = telf[0].ToString() + telf[1].ToString() + telf[2].ToString();
                            BLL.ClientesBLL.Insertar(new Clientes() {
                                ClienteId = Convert.ToInt32(ClienteIdTextBox.Text),
                                Organización = OrganizacionTextBox.Text,
                                Representante = RepresentanteTextBox.Text,
                                Dirección = DireccionTextBox.Text,
                                Teléfono = Convert.ToInt64(Tel)
                            });
                            Reiniciar();
                        }
                        else
                        {
                            TelefonoMaskedTextBox.Clear();
                            TelefonoMaskedTextBox.Focus();
                        }
                    }else
                    {
                        DireccionTextBox.Focus();
                    }
                }else
                {
                    RepresentanteTextBox.Focus();
                }

            }
            else
            {
                OrganizacionTextBox.Focus();
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(OrganizacionTextBox.Text))
            {
                if (!string.IsNullOrEmpty(RepresentanteTextBox.Text))
                {
                    if (!string.IsNullOrEmpty(DireccionTextBox.Text))
                    {
                        if(TelefonoMaskedTextBox.MaskFull)
                        {
                            var telf = TelefonoMaskedTextBox.Text.Split('(', ')', ' ', '-');
                            string Tel = telf[0].ToString() + telf[1].ToString() + telf[2].ToString();
                           if( BLL.ClientesBLL.Eliminar(new Clientes()
                            {
                                ClienteId = Convert.ToInt32(ClienteIdTextBox.Text),
                                Organización = OrganizacionTextBox.Text,
                                Representante = RepresentanteTextBox.Text,
                                Dirección = DireccionTextBox.Text,
                                Teléfono = Convert.ToInt64(Tel)
                           })) { MessageBox.Show("Registro Eliminado", "-- Operacion Exitosa --"); }
                        }
                    }
                }
            }
        }
    }
}
