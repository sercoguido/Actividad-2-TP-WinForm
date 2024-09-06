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
    }
}
