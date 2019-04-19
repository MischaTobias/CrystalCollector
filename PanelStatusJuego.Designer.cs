namespace InicioProyectoCrystalCollector
{
    partial class PanelStatusJuego
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
            this.components = new System.ComponentModel.Container();
            this.PanelAvatar = new System.Windows.Forms.Panel();
            this.PictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.TimePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelTimerSecs = new System.Windows.Forms.Label();
            this.PictureBoxTimer = new System.Windows.Forms.PictureBox();
            this.PanelPauseButton = new System.Windows.Forms.Panel();
            this.Num2 = new System.Windows.Forms.Label();
            this.Num1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PanelGems = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblPSegundos = new System.Windows.Forms.Label();
            this.PanelAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAvatar)).BeginInit();
            this.TimePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTimer)).BeginInit();
            this.PanelPauseButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PanelGems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelAvatar
            // 
            this.PanelAvatar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelAvatar.Controls.Add(this.PictureBoxAvatar);
            this.PanelAvatar.Location = new System.Drawing.Point(0, 0);
            this.PanelAvatar.Name = "PanelAvatar";
            this.PanelAvatar.Size = new System.Drawing.Size(201, 123);
            this.PanelAvatar.TabIndex = 0;
            // 
            // PictureBoxAvatar
            // 
            this.PictureBoxAvatar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxAvatar.Image = global::InicioProyectoCrystalCollector.Properties.Resources.MaleWarrior;
            this.PictureBoxAvatar.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxAvatar.Name = "PictureBoxAvatar";
            this.PictureBoxAvatar.Size = new System.Drawing.Size(201, 123);
            this.PictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxAvatar.TabIndex = 0;
            this.PictureBoxAvatar.TabStop = false;
            this.PictureBoxAvatar.Click += new System.EventHandler(this.PictureBoxAvatar_Click);
            // 
            // TimePanel
            // 
            this.TimePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimePanel.Controls.Add(this.lblPSegundos);
            this.TimePanel.Controls.Add(this.label1);
            this.TimePanel.Controls.Add(this.LabelTimerSecs);
            this.TimePanel.Controls.Add(this.PictureBoxTimer);
            this.TimePanel.Location = new System.Drawing.Point(207, 0);
            this.TimePanel.Name = "TimePanel";
            this.TimePanel.Size = new System.Drawing.Size(274, 123);
            this.TimePanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Supercell-Magic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 2;
            // 
            // LabelTimerSecs
            // 
            this.LabelTimerSecs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelTimerSecs.AutoSize = true;
            this.LabelTimerSecs.BackColor = System.Drawing.Color.Transparent;
            this.LabelTimerSecs.Font = new System.Drawing.Font("Supercell-Magic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTimerSecs.Location = new System.Drawing.Point(86, 56);
            this.LabelTimerSecs.Name = "LabelTimerSecs";
            this.LabelTimerSecs.Size = new System.Drawing.Size(0, 16);
            this.LabelTimerSecs.TabIndex = 1;
            this.LabelTimerSecs.Click += new System.EventHandler(this.label1_Click);
            // 
            // PictureBoxTimer
            // 
            this.PictureBoxTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxTimer.Image = global::InicioProyectoCrystalCollector.Properties.Resources.CircleTime;
            this.PictureBoxTimer.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxTimer.Name = "PictureBoxTimer";
            this.PictureBoxTimer.Size = new System.Drawing.Size(274, 123);
            this.PictureBoxTimer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxTimer.TabIndex = 0;
            this.PictureBoxTimer.TabStop = false;
            this.PictureBoxTimer.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // PanelPauseButton
            // 
            this.PanelPauseButton.Controls.Add(this.Num2);
            this.PanelPauseButton.Controls.Add(this.Num1);
            this.PanelPauseButton.Controls.Add(this.pictureBox2);
            this.PanelPauseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelPauseButton.Location = new System.Drawing.Point(720, 0);
            this.PanelPauseButton.Name = "PanelPauseButton";
            this.PanelPauseButton.Size = new System.Drawing.Size(225, 123);
            this.PanelPauseButton.TabIndex = 2;
            // 
            // Num2
            // 
            this.Num2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Num2.AutoSize = true;
            this.Num2.BackColor = System.Drawing.Color.Transparent;
            this.Num2.Font = new System.Drawing.Font("Supercell-Magic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num2.Location = new System.Drawing.Point(3, 56);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(79, 16);
            this.Num2.TabIndex = 3;
            this.Num2.Text = "of Num2";
            // 
            // Num1
            // 
            this.Num1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Num1.AutoSize = true;
            this.Num1.BackColor = System.Drawing.Color.Transparent;
            this.Num1.Font = new System.Drawing.Font("Supercell-Magic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num1.Location = new System.Drawing.Point(18, 34);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(50, 16);
            this.Num1.TabIndex = 2;
            this.Num1.Text = "Num1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::InicioProyectoCrystalCollector.Properties.Resources.Joya;
            this.pictureBox2.Location = new System.Drawing.Point(86, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(139, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // PanelGems
            // 
            this.PanelGems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelGems.Controls.Add(this.pictureBox1);
            this.PanelGems.Cursor = System.Windows.Forms.Cursors.Default;
            this.PanelGems.Location = new System.Drawing.Point(487, 0);
            this.PanelGems.Name = "PanelGems";
            this.PanelGems.Size = new System.Drawing.Size(227, 123);
            this.PanelGems.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::InicioProyectoCrystalCollector.Properties.Resources.PauseButton;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblPSegundos
            // 
            this.lblPSegundos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPSegundos.AutoSize = true;
            this.lblPSegundos.Font = new System.Drawing.Font("Supercell-Magic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSegundos.Location = new System.Drawing.Point(95, 73);
            this.lblPSegundos.Name = "lblPSegundos";
            this.lblPSegundos.Size = new System.Drawing.Size(84, 16);
            this.lblPSegundos.TabIndex = 3;
            this.lblPSegundos.Text = "Segundos";
            // 
            // PanelStatusJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.PanelGems);
            this.Controls.Add(this.PanelPauseButton);
            this.Controls.Add(this.TimePanel);
            this.Controls.Add(this.PanelAvatar);
            this.Name = "PanelStatusJuego";
            this.Size = new System.Drawing.Size(945, 123);
            this.PanelAvatar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAvatar)).EndInit();
            this.TimePanel.ResumeLayout(false);
            this.TimePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTimer)).EndInit();
            this.PanelPauseButton.ResumeLayout(false);
            this.PanelPauseButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PanelGems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelAvatar;
        private System.Windows.Forms.PictureBox PictureBoxAvatar;
        private System.Windows.Forms.Panel TimePanel;
        private System.Windows.Forms.PictureBox PictureBoxTimer;
        private System.Windows.Forms.Panel PanelPauseButton;
        private System.Windows.Forms.Panel PanelGems;
        private System.Windows.Forms.Label LabelTimerSecs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Num2;
        private System.Windows.Forms.Label Num1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblPSegundos;
    }
}
