namespace INGLES_PLATAFORMA
{
    partial class FormInicioSesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicioSesion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnInicioSesion = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRegistro = new System.Windows.Forms.LinkLabel();
            this.pbOcultarC = new System.Windows.Forms.PictureBox();
            this.pbMostrarC = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOcultarC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 489);
            this.panel1.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(377, 164);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(315, 22);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Text = "EMAIL";
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtEmail.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Location = new System.Drawing.Point(452, 92);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(158, 44);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "ENTRAR";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(377, 222);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(294, 22);
            this.txtContraseña.TabIndex = 3;
            this.txtContraseña.Text = "CONTRASEÑA";
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // btnInicioSesion
            // 
            this.btnInicioSesion.BackColor = System.Drawing.Color.Teal;
            this.btnInicioSesion.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicioSesion.Location = new System.Drawing.Point(387, 295);
            this.btnInicioSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInicioSesion.Name = "btnInicioSesion";
            this.btnInicioSesion.Size = new System.Drawing.Size(284, 49);
            this.btnInicioSesion.TabIndex = 4;
            this.btnInicioSesion.Text = "Iniciar Sesion";
            this.btnInicioSesion.UseVisualStyleBackColor = false;
            this.btnInicioSesion.Click += new System.EventHandler(this.btnInicioSesion_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(491, 398);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 16);
            this.linkLabel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "¿No tienes cuenta?";
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.LinkColor = System.Drawing.Color.White;
            this.lblRegistro.Location = new System.Drawing.Point(491, 418);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(69, 16);
            this.lblRegistro.TabIndex = 7;
            this.lblRegistro.TabStop = true;
            this.lblRegistro.Text = "Registrate";
            this.lblRegistro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // pbOcultarC
            // 
            this.pbOcultarC.Image = global::INGLES_PLATAFORMA.Properties.Resources.OCULTAR_CONTRASEÑA;
            this.pbOcultarC.Location = new System.Drawing.Point(684, 222);
            this.pbOcultarC.Name = "pbOcultarC";
            this.pbOcultarC.Size = new System.Drawing.Size(35, 35);
            this.pbOcultarC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOcultarC.TabIndex = 9;
            this.pbOcultarC.TabStop = false;
            this.pbOcultarC.Click += new System.EventHandler(this.pbOcultarC_Click);
            // 
            // pbMostrarC
            // 
            this.pbMostrarC.Image = global::INGLES_PLATAFORMA.Properties.Resources.MOSTRAR_CONTRASEÑA;
            this.pbMostrarC.Location = new System.Drawing.Point(684, 222);
            this.pbMostrarC.Name = "pbMostrarC";
            this.pbMostrarC.Size = new System.Drawing.Size(35, 35);
            this.pbMostrarC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMostrarC.TabIndex = 8;
            this.pbMostrarC.TabStop = false;
            this.pbMostrarC.Click += new System.EventHandler(this.pbMostrarC_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 395);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(731, 489);
            this.Controls.Add(this.pbMostrarC);
            this.Controls.Add(this.pbOcultarC);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnInicioSesion);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormInicioSesion";
            this.Opacity = 0.9D;
            this.Text = "FrmInicioSesion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbOcultarC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnInicioSesion;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblRegistro;
        private System.Windows.Forms.PictureBox pbMostrarC;
        private System.Windows.Forms.PictureBox pbOcultarC;
    }
}

