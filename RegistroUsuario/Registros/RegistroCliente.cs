using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;

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
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            var proximoCliente = BLL.ClientesBLL.UltimoCliente()+1;
            ClienteIdTextBox.Text = proximoCliente.ToString();
            ClienteIdTextBox.Enabled = false;
        }
    }
}
