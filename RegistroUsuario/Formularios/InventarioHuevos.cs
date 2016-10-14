using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroUsuario.Formularios
{
    public partial class InventarioHuevos : Form
    {
        public InventarioHuevos()
        {
            InitializeComponent();
            //var validacion = new Utileria(HuevoIdTextBox1, "Ejemplo: 01", HuevoIdTextBox1, "N");
            BLL.HuevosBLL.Insertar(new Entidades.Huevos() { HuevosId = 1, TipoDeHuevo = "Limpios", Existencia = 500 });
            BLL.HuevosBLL.Insertar(new Entidades.Huevos() { HuevosId = 2, TipoDeHuevo = "Sucios", Existencia = 200 });
            cargarTiposHuevos();
        }
        public void cargarTiposHuevos()
        {
            var lista = BLL.HuevosBLL.GetLista();
            foreach(Huevos t in lista)
                TipoDeHuevoComboBox1.Items.Add(t.TipoDeHuevo);
        }
        private void button1_Click(object sender, EventArgs e)
        {
           var lista = new List<Huevos>();
            if (string.IsNullOrEmpty(HuevoIdTextBox1.Text) && TipoDeHuevoComboBox1.SelectedItem == null)
                lista = BLL.HuevosBLL.GetLista();
            else if (string.IsNullOrEmpty(HuevoIdTextBox1.Text) && !string.IsNullOrEmpty(TipoDeHuevoComboBox1.SelectedItem.ToString()))
                lista.Add(BLL.HuevosBLL.Buscar(TipoDeHuevoComboBox1.SelectedItem.ToString()));
            else if (TipoDeHuevoComboBox1.SelectedItem == null && !string.IsNullOrEmpty(HuevoIdTextBox1.Text))
                lista.Add(BLL.HuevosBLL.Buscar(Convert.ToInt32(HuevoIdTextBox1.Text)));
            else
                lista.Add(BLL.HuevosBLL.Buscar(Convert.ToInt32(HuevoIdTextBox1.Text), TipoDeHuevoComboBox1.SelectedItem.ToString()));

            //HuevoIdTextBox1.Text = TipoDeHuevoComboBox1.SelectedItem.ToString();
            ConsultaDataGridView.DataSource = lista;
        }
    }
}
