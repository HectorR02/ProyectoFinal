using Entidades;
using System;
using System.Windows.Forms;

namespace RegistroUsuario.Formularios
{
    public partial class AjusteDeInventario : Form
    {
        public AjusteDeInventario()
        {
            InitializeComponent();
            var validar = new Utileria(CantidadTextBox, "Ejemplo: 20", CantidadTextBox, "N");
            //Temporal
            BLL.HuevosBLL.Insertar(new Huevos() { HuevosId = 1, TipoDeHuevo = "Limpios", Existencia = 500 });
            BLL.HuevosBLL.Insertar(new Huevos() { HuevosId = 2, TipoDeHuevo = "Sucios", Existencia = 200 });

            CargarTipos();
        }
        public void CargarTipos()
        {
            var lista = BLL.HuevosBLL.GetLista();
            foreach (Huevos t in lista)
                TipoDeHuevoComboBox.Items.Add(t.TipoDeHuevo);
            TipoDeHuevoComboBox.SelectedItem = "Limpios";
        }

        private void AumentarButton_Click(object sender, EventArgs e)
        {
            var huevo = BLL.HuevosBLL.Buscar(TipoDeHuevoComboBox.SelectedItem.ToString());
            huevo.Existencia += Convert.ToInt32(CantidadTextBox.Text);
            BLL.HuevosBLL.Actualizar(huevo);
            CantidadTextBox.Clear();
        }

        private void DisminuirButton_Click(object sender, EventArgs e)
        {
            var huevo = BLL.HuevosBLL.Buscar(TipoDeHuevoComboBox.SelectedItem.ToString());
            huevo.Existencia -= Convert.ToInt32(CantidadTextBox.Text);
            BLL.HuevosBLL.Actualizar(huevo);
            CantidadTextBox.Clear();
        }
    }
}
