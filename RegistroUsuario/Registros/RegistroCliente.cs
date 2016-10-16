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
    }
}
