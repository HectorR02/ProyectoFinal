﻿using System.Windows.Forms;

namespace RegistroUsuario.Formularios
{
    public partial class Inicio : Form
    {
        Form Padre;
        public Inicio()
        {
            InitializeComponent();
        }

        public Inicio(Form padre)
        {
            InitializeComponent();
            Padre = padre;
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
           Padre.Show();
        }

        private void inventarioToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var inventario = new InventarioHuevos();
            inventario.MdiParent = this;
            inventario.Show();
        }

        private void cambiarDeUsuarioToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //Hide();
            Close();
            Padre.Show();
           // Dispose();
            
        }

        private void usuariosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var RegUsuario = new RegistroUsuario();
            RegUsuario.MdiParent = this;
            RegUsuario.Show();
        }
    }
}
