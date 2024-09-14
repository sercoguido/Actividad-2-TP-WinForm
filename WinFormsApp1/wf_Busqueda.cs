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
    public partial class wf_Busqueda : Form
    {
        private List<articulo> listaArticulo;
        public wf_Busqueda()
        {
            InitializeComponent();
        }

        private void wf_Busqueda_Load(object sender, EventArgs e)
        {
            ArticuloServicio servicio = new ArticuloServicio();
            listaArticulo = servicio.listar();
            dgvArticulos.DataSource = listaArticulo;

            cargarImagen(listaArticulo[0].Imagen);
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            articulo seleccionado = (articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.Imagen);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                PbArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                PbArticulo.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }

        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
