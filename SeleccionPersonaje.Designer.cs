namespace InicioProyectoCrystalCollector
{
    partial class SeleccionPersonaje
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
            this.pBPersonaje = new System.Windows.Forms.PictureBox();
            this.pBCambiarPersonaje = new System.Windows.Forms.PictureBox();
            this.lblDaleUnNombre = new System.Windows.Forms.Label();
            this.pbCambiarPersonajeReves = new System.Windows.Forms.PictureBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBPersonaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCambiarPersonaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCambiarPersonajeReves)).BeginInit();
            this.SuspendLayout();
            // 
            // pBPersonaje
            // 
            this.pBPersonaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pBPersonaje.BackColor = System.Drawing.Color.Transparent;
            this.pBPersonaje.Image = global::InicioProyectoCrystalCollector.Properties.Resources.MaleWarrior;
            this.pBPersonaje.Location = new System.Drawing.Point(58, 61);
            this.pBPersonaje.Name = "pBPersonaje";
            this.pBPersonaje.Size = new System.Drawing.Size(234, 348);
            this.pBPersonaje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBPersonaje.TabIndex = 0;
            this.pBPersonaje.TabStop = false;
            // 
            // pBCambiarPersonaje
            // 
            this.pBCambiarPersonaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pBCambiarPersonaje.BackColor = System.Drawing.Color.Transparent;
            this.pBCambiarPersonaje.Image = global::InicioProyectoCrystalCollector.Properties.Resources.CambiarPersonaje;
            this.pBCambiarPersonaje.Location = new System.Drawing.Point(298, 220);
            this.pBCambiarPersonaje.Name = "pBCambiarPersonaje";
            this.pBCambiarPersonaje.Size = new System.Drawing.Size(34, 34);
            this.pBCambiarPersonaje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBCambiarPersonaje.TabIndex = 0;
            this.pBCambiarPersonaje.TabStop = false;
            this.pBCambiarPersonaje.Click += new System.EventHandler(this.pBCambiarPersonaje_Click);
            // 
            // lblDaleUnNombre
            // 
            this.lblDaleUnNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDaleUnNombre.AutoSize = true;
            this.lblDaleUnNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblDaleUnNombre.Font = new System.Drawing.Font("Supercell-Magic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaleUnNombre.Location = new System.Drawing.Point(358, 130);
            this.lblDaleUnNombre.Name = "lblDaleUnNombre";
            this.lblDaleUnNombre.Size = new System.Drawing.Size(303, 19);
            this.lblDaleUnNombre.TabIndex = 3;
            this.lblDaleUnNombre.Text = "Dale un nombre a tu personaje:";
            // 
            // pbCambiarPersonajeReves
            // 
            this.pbCambiarPersonajeReves.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbCambiarPersonajeReves.BackColor = System.Drawing.Color.Transparent;
            this.pbCambiarPersonajeReves.Image = global::InicioProyectoCrystalCollector.Properties.Resources.GirarPersonajeReves;
            this.pbCambiarPersonajeReves.Location = new System.Drawing.Point(18, 220);
            this.pbCambiarPersonajeReves.Name = "pbCambiarPersonajeReves";
            this.pbCambiarPersonajeReves.Size = new System.Drawing.Size(34, 34);
            this.pbCambiarPersonajeReves.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCambiarPersonajeReves.TabIndex = 4;
            this.pbCambiarPersonajeReves.TabStop = false;
            this.pbCambiarPersonajeReves.Click += new System.EventHandler(this.pbCambiarPersonajeReves_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.Font = new System.Drawing.Font("Supercell-Magic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(376, 172);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(263, 24);
            this.txtNombre.TabIndex = 5;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnContinuar.Font = new System.Drawing.Font("Supercell-Magic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.Location = new System.Drawing.Point(425, 220);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(176, 32);
            this.btnContinuar.TabIndex = 6;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // SeleccionPersonaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InicioProyectoCrystalCollector.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(665, 477);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.pbCambiarPersonajeReves);
            this.Controls.Add(this.pBCambiarPersonaje);
            this.Controls.Add(this.lblDaleUnNombre);
            this.Controls.Add(this.pBPersonaje);
            this.Name = "SeleccionPersonaje";
            this.Text = "Crystall Collector";
            ((System.ComponentModel.ISupportInitialize)(this.pBPersonaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCambiarPersonaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCambiarPersonajeReves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBPersonaje;
        private System.Windows.Forms.PictureBox pBCambiarPersonaje;
        private System.Windows.Forms.Label lblDaleUnNombre;
        private System.Windows.Forms.PictureBox pbCambiarPersonajeReves;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnContinuar;
    }
}