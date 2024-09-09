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
using dominio;
using servicio;

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
            Categoria cat = new Categoria();
            CategoriaServicio servicio = new CategoriaServicio();

            try
            {
                cat.Descripcion = txtNombre.Text;
                servicio.agregar(cat);

                MessageBox.Show("Categoria Agregada Satisfactoriamente!");
                Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAltaCategoria_Load(object sender, EventArgs e)
        {

        }
    }
}
