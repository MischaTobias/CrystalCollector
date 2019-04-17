namespace InicioProyectoCrystalCollector
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelStatusJuego1 = new InicioProyectoCrystalCollector.PanelStatusJuego();
            this.panelPreguntas1 = new InicioProyectoCrystalCollector.PanelPreguntas();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelStatusJuego1);
            this.panel1.Controls.Add(this.panelPreguntas1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 628);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelStatusJuego1
            // 
            this.panelStatusJuego1.BackColor = System.Drawing.Color.Linen;
            this.panelStatusJuego1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatusJuego1.Location = new System.Drawing.Point(0, 0);
            this.panelStatusJuego1.Name = "panelStatusJuego1";
            this.panelStatusJuego1.Size = new System.Drawing.Size(821, 123);
            this.panelStatusJuego1.TabIndex = 1;
            // 
            // panelPreguntas1
            // 
            this.panelPreguntas1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPreguntas1.Location = new System.Drawing.Point(0, 487);
            this.panelPreguntas1.Name = "panelPreguntas1";
            this.panelPreguntas1.Size = new System.Drawing.Size(821, 141);
            this.panelPreguntas1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 628);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Crystal Collector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private PanelPreguntas panelPreguntas1;
        private PanelStatusJuego panelStatusJuego1;
    }
}

