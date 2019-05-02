namespace InicioProyectoCrystalCollector
{
    partial class Instrucciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instrucciones));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblCerrarVentana = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Supercell-Magic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(54, 35);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(132, 18);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Instrucciones:";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.BackColor = System.Drawing.Color.Transparent;
            this.lblTexto.Font = new System.Drawing.Font("Supercell-Magic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.Color.White;
            this.lblTexto.Location = new System.Drawing.Point(59, 70);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(76, 16);
            this.lblTexto.TabIndex = 1;
            this.lblTexto.Text = "lblTexto";
            // 
            // lblCerrarVentana
            // 
            this.lblCerrarVentana.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCerrarVentana.AutoSize = true;
            this.lblCerrarVentana.BackColor = System.Drawing.Color.Transparent;
            this.lblCerrarVentana.Font = new System.Drawing.Font("Supercell-Magic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrarVentana.ForeColor = System.Drawing.Color.White;
            this.lblCerrarVentana.Location = new System.Drawing.Point(631, 423);
            this.lblCerrarVentana.Name = "lblCerrarVentana";
            this.lblCerrarVentana.Size = new System.Drawing.Size(148, 18);
            this.lblCerrarVentana.TabIndex = 2;
            this.lblCerrarVentana.Text = "Cerrar Ventana";
            this.lblCerrarVentana.Click += new System.EventHandler(this.lblCerrarVentana_Click);
            this.lblCerrarVentana.MouseEnter += new System.EventHandler(this.lblCerrarVentana_MouseEnter);
            this.lblCerrarVentana.MouseLeave += new System.EventHandler(this.lblCerrarVentana_MouseLeave);
            // 
            // Instrucciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InicioProyectoCrystalCollector.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(791, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lblCerrarVentana);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Instrucciones";
            this.Text = "Instrucciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblCerrarVentana;
    }
}