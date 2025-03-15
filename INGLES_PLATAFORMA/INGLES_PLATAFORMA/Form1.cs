using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace INGLES_PLATAFORMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.BackColor = ColorTranslator.FromHtml("#0097b2");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           


        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black; // Cambia el color del texto para que no parezca deshabilitado
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Black; // Muestra el texto en gris para simular un placeholder
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black; // Cambia el color del texto para que no parezca deshabilitado
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.Black; // Muestra el texto en gris para simular un placeholder
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistro registro = new FrmRegistro(); // Usa la clase frmLogin en lugar de Form
            this.Hide(); // Oculta el formulario actual
           registro.Show();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin(); // Usa la clase frmLogin en lugar de Form
            this.Hide(); // Oculta el formulario actual
            login.Show();
        }

    }
}
