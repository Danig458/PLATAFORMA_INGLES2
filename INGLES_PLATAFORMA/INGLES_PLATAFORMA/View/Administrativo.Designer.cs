﻿namespace INGLES_PLATAFORMA
{
    partial class Administrativo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAdministrativo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lblAdministrativo);
            this.panel1.Location = new System.Drawing.Point(-7, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1292, 119);
            this.panel1.TabIndex = 0;
            // 
            // lblAdministrativo
            // 
            this.lblAdministrativo.AutoSize = true;
            this.lblAdministrativo.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrativo.Location = new System.Drawing.Point(403, 46);
            this.lblAdministrativo.Name = "lblAdministrativo";
            this.lblAdministrativo.Size = new System.Drawing.Size(468, 34);
            this.lblAdministrativo.TabIndex = 1;
            this.lblAdministrativo.Text = "El usuario no es un Administrativo";
            this.lblAdministrativo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Administrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 603);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Administrativo";
            this.Text = "Administrativo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAdministrativo;
    }
}