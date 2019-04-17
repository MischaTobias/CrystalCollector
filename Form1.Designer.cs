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
            this.BtnTablero6x7 = new System.Windows.Forms.Button();
            this.BtnTablero10x10 = new System.Windows.Forms.Button();
            this.BtnTablero5x6 = new System.Windows.Forms.Button();
            this.BtnTablero4x5 = new System.Windows.Forms.Button();
            this.BtnTablero3x3 = new System.Windows.Forms.Button();
            this.panelStatusJuego1 = new InicioProyectoCrystalCollector.PanelStatusJuego();
            this.panelPreguntas1 = new InicioProyectoCrystalCollector.PanelPreguntas();
            this.TableroDeJuego = new Tablero();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnTablero6x7);
            this.panel1.Controls.Add(this.BtnTablero10x10);
            this.panel1.Controls.Add(this.BtnTablero5x6);
            this.panel1.Controls.Add(this.BtnTablero4x5);
            this.panel1.Controls.Add(this.BtnTablero3x3);
            this.panel1.Controls.Add(this.TableroDeJuego);
            this.panel1.Controls.Add(this.panelStatusJuego1);
            this.panel1.Controls.Add(this.panelPreguntas1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 628);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BtnTablero6x7
            // 
            this.BtnTablero6x7.Location = new System.Drawing.Point(654, 278);
            this.BtnTablero6x7.Name = "BtnTablero6x7";
            this.BtnTablero6x7.Size = new System.Drawing.Size(92, 30);
            this.BtnTablero6x7.TabIndex = 7;
            this.BtnTablero6x7.Text = "6 x 7";
            this.BtnTablero6x7.UseVisualStyleBackColor = true;
            this.BtnTablero6x7.Click += new System.EventHandler(this.BtnTablero6x7_Click);
            // 
            // BtnTablero10x10
            // 
            this.BtnTablero10x10.Location = new System.Drawing.Point(654, 314);
            this.BtnTablero10x10.Name = "BtnTablero10x10";
            this.BtnTablero10x10.Size = new System.Drawing.Size(92, 30);
            this.BtnTablero10x10.TabIndex = 6;
            this.BtnTablero10x10.Text = "10 x 10";
            this.BtnTablero10x10.UseVisualStyleBackColor = true;
            this.BtnTablero10x10.Click += new System.EventHandler(this.BtnTablero10x10_Click);
            // 
            // BtnTablero5x6
            // 
            this.BtnTablero5x6.Location = new System.Drawing.Point(654, 242);
            this.BtnTablero5x6.Name = "BtnTablero5x6";
            this.BtnTablero5x6.Size = new System.Drawing.Size(92, 30);
            this.BtnTablero5x6.TabIndex = 5;
            this.BtnTablero5x6.Text = "5 x 6";
            this.BtnTablero5x6.UseVisualStyleBackColor = true;
            this.BtnTablero5x6.Click += new System.EventHandler(this.BtnTablero5x6_Click);
            // 
            // BtnTablero4x5
            // 
            this.BtnTablero4x5.Location = new System.Drawing.Point(654, 206);
            this.BtnTablero4x5.Name = "BtnTablero4x5";
            this.BtnTablero4x5.Size = new System.Drawing.Size(92, 30);
            this.BtnTablero4x5.TabIndex = 4;
            this.BtnTablero4x5.Text = "4 x 5";
            this.BtnTablero4x5.UseVisualStyleBackColor = true;
            this.BtnTablero4x5.Click += new System.EventHandler(this.BtnTablero4x5_Click);
            // 
            // BtnTablero3x3
            // 
            this.BtnTablero3x3.Location = new System.Drawing.Point(654, 170);
            this.BtnTablero3x3.Name = "BtnTablero3x3";
            this.BtnTablero3x3.Size = new System.Drawing.Size(92, 30);
            this.BtnTablero3x3.TabIndex = 3;
            this.BtnTablero3x3.Text = "3 x 3";
            this.BtnTablero3x3.UseVisualStyleBackColor = true;
            this.BtnTablero3x3.Click += new System.EventHandler(this.BtnTablero3x3_Click);
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
            // TableroDeJuego
            // 
            this.TableroDeJuego.BackColor = System.Drawing.Color.Gray;
            this.TableroDeJuego.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.TableroDeJuego.ColumnCount = 3;
            this.TableroDeJuego.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableroDeJuego.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TableroDeJuego.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TableroDeJuego.Location = new System.Drawing.Point(43, 147);
            this.TableroDeJuego.Name = "TableroDeJuego";
            this.TableroDeJuego.RowCount = 3;
            this.TableroDeJuego.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableroDeJuego.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableroDeJuego.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableroDeJuego.Size = new System.Drawing.Size(572, 309);
            this.TableroDeJuego.TabIndex = 2;
            this.TableroDeJuego.Paint += new System.Windows.Forms.PaintEventHandler(this.TableroDeJuego_Paint);
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
        private System.Windows.Forms.Button BtnTablero10x10;
        private System.Windows.Forms.Button BtnTablero5x6;
        private System.Windows.Forms.Button BtnTablero4x5;
        private System.Windows.Forms.Button BtnTablero3x3;
        private System.Windows.Forms.Button BtnTablero6x7;
        private Tablero TableroDeJuego;
    }
}

