namespace InicioProyectoCrystalCollector
{
    partial class PanelPreguntas
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelPreguntas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Respuesta3 = new System.Windows.Forms.RadioButton();
            this.Respuesta2 = new System.Windows.Forms.RadioButton();
            this.Respuesta1 = new System.Windows.Forms.RadioButton();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnResponder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 150);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel3.Controls.Add(this.btnResponder);
            this.panel3.Controls.Add(this.Respuesta3);
            this.panel3.Controls.Add(this.Respuesta2);
            this.panel3.Controls.Add(this.Respuesta1);
            this.panel3.Controls.Add(this.lblPregunta);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(560, 150);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Respuesta3
            // 
            this.Respuesta3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Respuesta3.AutoSize = true;
            this.Respuesta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Respuesta3.Location = new System.Drawing.Point(387, 69);
            this.Respuesta3.Name = "Respuesta3";
            this.Respuesta3.Size = new System.Drawing.Size(92, 17);
            this.Respuesta3.TabIndex = 5;
            this.Respuesta3.TabStop = true;
            this.Respuesta3.Text = "Respuesta3";
            this.Respuesta3.UseVisualStyleBackColor = true;
            this.Respuesta3.CheckedChanged += new System.EventHandler(this.Respuesta3_CheckedChanged);
            // 
            // Respuesta2
            // 
            this.Respuesta2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Respuesta2.AutoSize = true;
            this.Respuesta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Respuesta2.Location = new System.Drawing.Point(201, 69);
            this.Respuesta2.Name = "Respuesta2";
            this.Respuesta2.Size = new System.Drawing.Size(92, 17);
            this.Respuesta2.TabIndex = 4;
            this.Respuesta2.TabStop = true;
            this.Respuesta2.Text = "Respuesta2";
            this.Respuesta2.UseVisualStyleBackColor = true;
            this.Respuesta2.CheckedChanged += new System.EventHandler(this.Respuesta2_CheckedChanged);
            // 
            // Respuesta1
            // 
            this.Respuesta1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Respuesta1.AutoSize = true;
            this.Respuesta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Respuesta1.Location = new System.Drawing.Point(26, 69);
            this.Respuesta1.Name = "Respuesta1";
            this.Respuesta1.Size = new System.Drawing.Size(92, 17);
            this.Respuesta1.TabIndex = 3;
            this.Respuesta1.TabStop = true;
            this.Respuesta1.Text = "Respuesta1";
            this.Respuesta1.UseVisualStyleBackColor = true;
            this.Respuesta1.CheckedChanged += new System.EventHandler(this.Respuesta1_CheckedChanged);
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.Location = new System.Drawing.Point(98, 20);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(156, 13);
            this.lblPregunta.TabIndex = 1;
            this.lblPregunta.Text = "Aquí van las preguntas :D";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TROLL:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 150);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnResponder
            // 
            this.btnResponder.Location = new System.Drawing.Point(26, 102);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(127, 28);
            this.btnResponder.TabIndex = 6;
            this.btnResponder.Text = "Responder";
            this.btnResponder.UseVisualStyleBackColor = true;
            this.btnResponder.Click += new System.EventHandler(this.btnResponder_Click);
            // 
            // PanelPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "PanelPreguntas";
            this.Size = new System.Drawing.Size(760, 150);
            this.Load += new System.EventHandler(this.PanelPreguntas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Respuesta3;
        private System.Windows.Forms.RadioButton Respuesta2;
        private System.Windows.Forms.RadioButton Respuesta1;
        private System.Windows.Forms.Button btnResponder;
    }
}
