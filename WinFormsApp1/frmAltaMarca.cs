using dominio;
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
    public partial class frmAltaMarca : Form
    {
        public frmAltaMarca()
        {
            InitializeComponent();
        }

        private void frmAltaMarca_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            Marca mar = new Marca();
            MarcaServicio servicio = new MarcaServicio();

            try
            {
                mar.Descripcion = txtNombre.Text;
                servicio.agregar(mar);

                MessageBox.Show("Marca Agregada Satisfactoriamente!");
                Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
