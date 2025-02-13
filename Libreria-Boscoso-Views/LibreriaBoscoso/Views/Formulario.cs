using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaBoscoso.Views.InicioLogin;

namespace LibreriaBoscoso.Views
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void logoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Formulario_Load(object sender, EventArgs e)
        {

        }

        private void txtTitulo_Enter(object sender, EventArgs e)
        {
            txtTitulo.Clear();
        }

        private void txtAutor_Enter(object sender, EventArgs e)
        {
            txtAutor.Clear();
        }

        private void txtPrecio_Enter(object sender, EventArgs e)
        {
            txtPrecio.Clear();
        }

        private void txtStock_Enter(object sender, EventArgs e)
        {
            txtStock.Clear();
        }

        private void txtDescripcion_Enter(object sender, EventArgs e)
        {
            txtDescripcion.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Formulario_Load_1(object sender, EventArgs e)
        {

        }
    }
}
