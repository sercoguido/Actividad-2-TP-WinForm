using servicio;
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
    public partial class wf_MarcasCategorias : Form
    {
        public wf_MarcasCategorias()
        {
            InitializeComponent();
        }

        private void btn_AgregarMarcasMC_Click(object sender, EventArgs e)
        {

        }

        private void btn_AgregarCategoriasMC_Click(object sender, EventArgs e)
        {
            frmAltaCategoria alta = new frmAltaCategoria();
            alta.ShowDialog();
        }

        private void wf_MarcasCategorias_Load(object sender, EventArgs e)
        {
            MarcaServicio servicio = new MarcaServicio();
            dgvMarcas.DataSource = servicio.listar();


            CategoriaServicio servicio2 = new CategoriaServicio();
            dgvCategorias.DataSource = servicio2.listar();
        }
    }
}
