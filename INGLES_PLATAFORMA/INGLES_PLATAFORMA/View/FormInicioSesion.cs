using INGLES_PLATAFORMA.Controller;
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
    public partial class FormInicioSesion : Form
    {
        public FormInicioSesion()
        {
            InitializeComponent();
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
            if (txtEmail.Text == "USUARIO")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black; // Cambia el color del texto para que no parezca deshabilitado
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "USUARIO";
                txtEmail.ForeColor = Color.Black; // Muestra el texto en gris para simular un placeholder
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.PasswordChar = '●';
                txtContraseña.ForeColor = Color.Black; // Cambia el color del texto para que no parezca deshabilitado
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.Black; // Muestra el texto en gris para simular un placeholder
                txtContraseña.PasswordChar = '\0';
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
            UsuarioController usuario = new UsuarioController(txtEmail.Text, txtContraseña.Text);
            if (usuario.ValidarUsuario())
            {
                MessageBox.Show("Inicio de sesión exitoso");
                FrmLogin login = new FrmLogin(); // Usa la clase frmLogin en lugar de Form
                this.Hide(); // Oculta el formulario actual
                login.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void pbMostrarC_Click(object sender, EventArgs e)
        {
            //imagen ocultar la mandamos al frente
            pbOcultarC.BringToFront();
            txtContraseña.PasswordChar = '\0';
        }

        private void pbOcultarC_Click(object sender, EventArgs e)
        {
            //imagen mostrar la mandamos al frente
            pbMostrarC.BringToFront();
            txtContraseña.PasswordChar = '●';
        }
    }
}
