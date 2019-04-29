namespace InicioProyectoCrystalCollector
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIniciarNuevaPartida = new System.Windows.Forms.Button();
            this.btnInstrucciones = new System.Windows.Forms.Button();
            this.lblAcercaDe = new System.Windows.Forms.Label();
            this.lblSalir = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(131, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnIniciarNuevaPartida
            // 
            this.btnIniciarNuevaPartida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIniciarNuevaPartida.Font = new System.Drawing.Font("Supercell-Magic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarNuevaPartida.Location = new System.Drawing.Point(133, 228);
            this.btnIniciarNuevaPartida.Name = "btnIniciarNuevaPartida";
            this.btnIniciarNuevaPartida.Size = new System.Drawing.Size(300, 38);
            this.btnIniciarNuevaPartida.TabIndex = 1;
            this.btnIniciarNuevaPartida.Text = "Iniciar Nueva Partida";
            this.btnIniciarNuevaPartida.UseVisualStyleBackColor = true;
            this.btnIniciarNuevaPartida.Click += new System.EventHandler(this.btnIniciarNuevaPartida_Click);
            // 
            // btnInstrucciones
            // 
            this.btnInstrucciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInstrucciones.Font = new System.Drawing.Font("Supercell-Magic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstrucciones.Location = new System.Drawing.Point(131, 272);
            this.btnInstrucciones.Name = "btnInstrucciones";
            this.btnInstrucciones.Size = new System.Drawing.Size(303, 38);
            this.btnInstrucciones.TabIndex = 2;
            this.btnInstrucciones.Text = "Instrucciones";
            this.btnInstrucciones.UseVisualStyleBackColor = true;
            this.btnInstrucciones.Click += new System.EventHandler(this.btnInstrucciones_Click);
            // 
            // lblAcercaDe
            // 
            this.lblAcercaDe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAcercaDe.AutoSize = true;
            this.lblAcercaDe.BackColor = System.Drawing.Color.Transparent;
            this.lblAcercaDe.Font = new System.Drawing.Font("Supercell-Magic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcercaDe.ForeColor = System.Drawing.Color.White;
            this.lblAcercaDe.Location = new System.Drawing.Point(12, 453);
            this.lblAcercaDe.Name = "lblAcercaDe";
            this.lblAcercaDe.Size = new System.Drawing.Size(232, 16);
            this.lblAcercaDe.TabIndex = 3;
            this.lblAcercaDe.Text = "Acerca de Crystal Collector";
            this.lblAcercaDe.Click += new System.EventHandler(this.lblAcercaDe_Click);
            this.lblAcercaDe.MouseEnter += new System.EventHandler(this.lblAcercaDe_MouseEnter);
            this.lblAcercaDe.MouseLeave += new System.EventHandler(this.lblAcercaDe_MouseLeave);
            // 
            // lblSalir
            // 
            this.lblSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSalir.AutoSize = true;
            this.lblSalir.BackColor = System.Drawing.Color.Transparent;
            this.lblSalir.Font = new System.Drawing.Font("Supercell-Magic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalir.ForeColor = System.Drawing.Color.White;
            this.lblSalir.Location = new System.Drawing.Point(437, 453);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(122, 16);
            this.lblSalir.TabIndex = 4;
            this.lblSalir.Text = "Salir del juego";
            this.lblSalir.Click += new System.EventHandler(this.lblSalir_Click);
            this.lblSalir.MouseEnter += new System.EventHandler(this.lblSalir_MouseEnter);
            this.lblSalir.MouseLeave += new System.EventHandler(this.lblSalir_MouseLeave);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(571, 478);
            this.Controls.Add(this.lblSalir);
            this.Controls.Add(this.lblAcercaDe);
            this.Controls.Add(this.btnInstrucciones);
            this.Controls.Add(this.btnIniciarNuevaPartida);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.Text = "Crystall Collector";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIniciarNuevaPartida;
        private System.Windows.Forms.Button btnInstrucciones;
        private System.Windows.Forms.Label lblAcercaDe;
        private System.Windows.Forms.Label lblSalir;
    }
}