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

namespace INGLES_PLATAFORMA
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {

            txtNombre.Tag = "NOMBRE";
            txtApellidos.Tag = "APELLIDO";
            txtEmail.Tag = "EMAIL";
            txtContraseña.Tag = "CONTRASEÑA";
            txtConfirmarContraseña.Tag = "CONFIRMAR CONTRASEÑA";

            // Establecer los valores iniciales y colores
            txtNombre.Text = txtNombre.Tag.ToString();
            txtNombre.ForeColor = Color.Gray;

            txtApellidos.Text = txtApellidos.Tag.ToString();
            txtApellidos.ForeColor = Color.Gray;

            txtEmail.Text = txtEmail.Tag.ToString();
            txtEmail.ForeColor = Color.Gray;

            txtContraseña.Text = txtContraseña.Tag.ToString();
            txtContraseña.ForeColor = Color.Gray;

            txtConfirmarContraseña.Text = txtConfirmarContraseña.Tag.ToString();
            txtConfirmarContraseña.ForeColor = Color.Gray;

            // Asignar eventos Enter y Leave
            txtNombre.Enter += TextBox_Focus;
            txtNombre.Leave += TextBox_Focus;

            txtApellidos.Enter += TextBox_Focus;
            txtApellidos.Leave += TextBox_Focus;

            txtEmail.Enter += TextBox_Focus;
            txtEmail.Leave += TextBox_Focus;

            txtContraseña.Enter += TextBox_Focus;
            txtContraseña.Leave += TextBox_Focus;

            txtConfirmarContraseña.Enter += TextBox_Focus;
            txtConfirmarContraseña.Leave += TextBox_Focus;

            //Establecer el foco en otro control invisible
            this.ActiveControl = label1;

        }

        private void TextBox_Focus(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt == null) return;

            // Obtener el placeholder del TextBox (lo guardamos en la propiedad `Tag`)
            string placeholder = txt.Tag?.ToString() ?? "";

            if (txt.Focused) // Cuando el TextBox obtiene el foco (Enter)
            {
                if (txt.Text == placeholder)
                {
                    txt.Text = "";
                    txt.ForeColor = Color.Black; // Texto normal
                }
            }
            else // Cuando el TextBox pierde el foco (Leave)
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    txt.Text = placeholder;
                    txt.ForeColor = Color.Gray; // Simular placeholder
                }
            }
        }

        private void lblIniciarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormInicioSesion entrar = new FormInicioSesion(); // Usa la clase frmLogin en lugar de Form
            this.Hide(); // Oculta el formulario actual
            entrar.Show();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            RegistroController  registro = new RegistroController(txtNombre.Text,txtApellidos.Text,txtEmail.Text,txtContraseña.Text);
            string Mensaje = (registro.GuardarUsuario()) ? "Registro completado" : "Ocurrio un error";
            MessageBox.Show(Mensaje);
 
        }

    }
}
