using System.Windows.Forms;

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
            Padre.Close();
        }

        private void inventarioToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var inventario = new InventarioHuevos();
            inventario.MdiParent = this;
            inventario.Show();
        }
    }
}
