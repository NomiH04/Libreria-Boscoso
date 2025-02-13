using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaBoscoso.Views.InicioLogin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string password = txtContrasena.Text;
            if (user=="sandia"&&password=="123")
            {
                VendedorPrincipal vendedorPrincipal = new VendedorPrincipal();
                MessageBox.Show("Bienvenido");
                vendedorPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            txtUsuario.Clear();
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            txtContrasena.Clear();
        }
    }
}
