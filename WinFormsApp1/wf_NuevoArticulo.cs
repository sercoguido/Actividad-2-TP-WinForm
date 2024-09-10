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

namespace GestionCatalogo
{
    public partial class wf_NuevoArticulo : Form
    {
        public wf_NuevoArticulo()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            articulo art = new articulo();
            ArticuloServicio servicio = new ArticuloServicio();

            try
            {
                art.Codigo = txtCodigo.Text;
                art.Nombre = txtNombre.Text;
                art.Descripcion = inpDescripcion.Text;
                art.Marca = (Marca)CbMarcas.SelectedItem;
                art.Categoria = (Categoria)CbCategoria.SelectedItem;
                decimal precio;
                if (decimal.TryParse(inpPrecio.Text, out precio))
                {
                    art.Precio = precio;
                }
                else
                {
                    // Manejar error, el valor no es un número válido
                    MessageBox.Show("Ingrese un valor numérico válido para el precio.");
                }

                servicio.agregar(art);

                MessageBox.Show("Articulo Agregado Satisfactoriamente!");
                Close();

            }
            catch (Exception)
            {

                throw;
            }

        }
        private void txt_Edad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            MarcaServicio marcaServicio = new MarcaServicio();
            CategoriaServicio categoriaServicio = new CategoriaServicio();
            try
            {
                CbMarcas.DataSource = marcaServicio.listar();
                CbCategoria.DataSource = categoriaServicio.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listBoxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void input_NombreNA_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbUrlImagen_Leave(object sender, EventArgs e)
        {
        }

    }
}
