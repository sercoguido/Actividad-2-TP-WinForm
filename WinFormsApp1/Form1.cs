namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void entradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nuevo_Articulo ventana = new Nuevo_Articulo();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
