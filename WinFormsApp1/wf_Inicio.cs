using WinFormsApp1;

namespace GestionCatalogo
{
    public partial class wf_Inicio : Form
    {
        public wf_Inicio()
        {
            InitializeComponent();
        }

        private void btn_AgregarArticulo_Click_1(object sender, EventArgs e)
        {
            wf_NuevoArticulo formNuevoArticulo = new wf_NuevoArticulo();
            formNuevoArticulo.ShowDialog();
        }

        private void wf_Inicio_Load(object sender, EventArgs e)
        {

        }

        private void btn_EliminarArticulo_Click_1(object sender, EventArgs e)
        {
            wf_EliminarArticulo FormEliminarArticulo = new wf_EliminarArticulo();
            FormEliminarArticulo.ShowDialog();
        }

        private void btn_ModificarArticulo_Click(object sender, EventArgs e)
        {
            wf_ModificarArticulo FormModificarArticulo = new wf_ModificarArticulo();
            FormModificarArticulo.ShowDialog();
        }

        private void btn_DetallesArticulos_Click(object sender, EventArgs e)
        {
            wf_Detalles FormDetalles = new wf_Detalles();
            FormDetalles.ShowDialog();
        }

        private void btn_MarcasCategorias_Click(object sender, EventArgs e)
        {
            wf_MarcasCategorias FormMarcasCategorias = new wf_MarcasCategorias();
            FormMarcasCategorias.ShowDialog();
        }
    }
}
