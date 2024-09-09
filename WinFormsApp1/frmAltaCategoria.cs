using GestionCatalogo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmAltaCategoria : Form
    {
        public frmAltaCategoria()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            categoria nuevaCategoria = new categoria();
            CategoriaServicio categoriaServicio = new CategoriaServicio();

            try
            {
                nuevaCategoria.Nombre = txtNombre.Text;

                categoriaServicio.Agregar(nuevaCategoria);

                MessageBox.Show("¡Categoría añadida correctamente!");

                Close();
            }
            catch (Exception ex)
            {
                // Mostrar mensaje con el error
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
