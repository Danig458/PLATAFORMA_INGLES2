namespace INGLES_PLATAFORMA
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.Iconrestaurar = new System.Windows.Forms.PictureBox();
            this.Iconmaximizar = new System.Windows.Forms.PictureBox();
            this.Iconminimizar = new System.Windows.Forms.PictureBox();
            this.Iconcerrar = new System.Windows.Forms.PictureBox();
            this.btnSlide = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuVertical.SuspendLayout();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Iconrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iconmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iconminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iconcerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(250, 603);
            this.MenuVertical.TabIndex = 0;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.Controls.Add(this.Iconmaximizar);
            this.BarraTitulo.Controls.Add(this.Iconminimizar);
            this.BarraTitulo.Controls.Add(this.Iconcerrar);
            this.BarraTitulo.Controls.Add(this.btnSlide);
            this.BarraTitulo.Controls.Add(this.Iconrestaurar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(250, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1032, 50);
            this.BarraTitulo.TabIndex = 1;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // Iconrestaurar
            // 
            this.Iconrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Iconrestaurar.Image = global::INGLES_PLATAFORMA.Properties.Resources.maximizar_button;
            this.Iconrestaurar.Location = new System.Drawing.Point(969, 3);
            this.Iconrestaurar.Name = "Iconrestaurar";
            this.Iconrestaurar.Size = new System.Drawing.Size(27, 24);
            this.Iconrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Iconrestaurar.TabIndex = 4;
            this.Iconrestaurar.TabStop = false;
            this.Iconrestaurar.Visible = false;
            this.Iconrestaurar.Click += new System.EventHandler(this.Iconrestaurar_Click_1);
            // 
            // Iconmaximizar
            // 
            this.Iconmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Iconmaximizar.Image = global::INGLES_PLATAFORMA.Properties.Resources.maximizar;
            this.Iconmaximizar.Location = new System.Drawing.Point(969, 3);
            this.Iconmaximizar.Name = "Iconmaximizar";
            this.Iconmaximizar.Size = new System.Drawing.Size(27, 24);
            this.Iconmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Iconmaximizar.TabIndex = 3;
            this.Iconmaximizar.TabStop = false;
            this.Iconmaximizar.Click += new System.EventHandler(this.Iconmaximizar_Click);
            // 
            // Iconminimizar
            // 
            this.Iconminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Iconminimizar.Image = global::INGLES_PLATAFORMA.Properties.Resources.min2;
            this.Iconminimizar.Location = new System.Drawing.Point(936, 3);
            this.Iconminimizar.Name = "Iconminimizar";
            this.Iconminimizar.Size = new System.Drawing.Size(27, 24);
            this.Iconminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Iconminimizar.TabIndex = 2;
            this.Iconminimizar.TabStop = false;
            this.Iconminimizar.Click += new System.EventHandler(this.Iconminimizar_Click);
            // 
            // Iconcerrar
            // 
            this.Iconcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Iconcerrar.Image = global::INGLES_PLATAFORMA.Properties.Resources.delete_2;
            this.Iconcerrar.Location = new System.Drawing.Point(1002, 3);
            this.Iconcerrar.Name = "Iconcerrar";
            this.Iconcerrar.Size = new System.Drawing.Size(27, 24);
            this.Iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Iconcerrar.TabIndex = 1;
            this.Iconcerrar.TabStop = false;
            this.Iconcerrar.Click += new System.EventHandler(this.Iconcerrar_Click);
            // 
            // btnSlide
            // 
            this.btnSlide.BackColor = System.Drawing.SystemColors.Control;
            this.btnSlide.Image = global::INGLES_PLATAFORMA.Properties.Resources.menu;
            this.btnSlide.Location = new System.Drawing.Point(0, 3);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(57, 47);
            this.btnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSlide.TabIndex = 0;
            this.btnSlide.TabStop = false;
            this.btnSlide.Click += new System.EventHandler(this.btnSlide_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::INGLES_PLATAFORMA.Properties.Resources.logo_2;
            this.pictureBox1.Location = new System.Drawing.Point(-19, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 603);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(7, 6);
            this.Name = "FrmLogin";
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.MenuVertical.ResumeLayout(false);
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Iconrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iconmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iconminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iconcerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnSlide;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Iconcerrar;
        private System.Windows.Forms.PictureBox Iconminimizar;
        private System.Windows.Forms.PictureBox Iconmaximizar;
        private System.Windows.Forms.PictureBox Iconrestaurar;
    }
}