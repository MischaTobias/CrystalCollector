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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelStatusJuego));
            this.PanelAvatar = new System.Windows.Forms.Panel();
            this.PictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.TimePanel = new System.Windows.Forms.Panel();
            this.PictureBoxTimer = new System.Windows.Forms.PictureBox();
            this.PanelPauseButton = new System.Windows.Forms.Panel();
            this.PanelGems = new System.Windows.Forms.Panel();
            this.LabelTimerSecs = new System.Windows.Forms.Label();
            this.PanelAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAvatar)).BeginInit();
            this.TimePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelAvatar
            // 
            this.PanelAvatar.Controls.Add(this.PictureBoxAvatar);
            this.PanelAvatar.Location = new System.Drawing.Point(0, 0);
            this.PanelAvatar.Name = "PanelAvatar";
            this.PanelAvatar.Size = new System.Drawing.Size(201, 123);
            this.PanelAvatar.TabIndex = 0;
            // 
            // PictureBoxAvatar
            // 
            this.PictureBoxAvatar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxAvatar.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxAvatar.Image")));
            this.PictureBoxAvatar.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxAvatar.Name = "PictureBoxAvatar";
            this.PictureBoxAvatar.Size = new System.Drawing.Size(201, 123);
            this.PictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxAvatar.TabIndex = 0;
            this.PictureBoxAvatar.TabStop = false;
            // 
            // TimePanel
            // 
            this.TimePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimePanel.Controls.Add(this.LabelTimerSecs);
            this.TimePanel.Controls.Add(this.PictureBoxTimer);
            this.TimePanel.Location = new System.Drawing.Point(207, 0);
            this.TimePanel.Name = "TimePanel";
            this.TimePanel.Size = new System.Drawing.Size(274, 123);
            this.TimePanel.TabIndex = 1;
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
            this.PanelPauseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelPauseButton.Location = new System.Drawing.Point(720, 0);
            this.PanelPauseButton.Name = "PanelPauseButton";
            this.PanelPauseButton.Size = new System.Drawing.Size(225, 123);
            this.PanelPauseButton.TabIndex = 2;
            // 
            // PanelGems
            // 
            this.PanelGems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelGems.Cursor = System.Windows.Forms.Cursors.Default;
            this.PanelGems.Location = new System.Drawing.Point(487, 0);
            this.PanelGems.Name = "PanelGems";
            this.PanelGems.Size = new System.Drawing.Size(227, 123);
            this.PanelGems.TabIndex = 3;
            // 
            // LabelTimerSecs
            // 
            this.LabelTimerSecs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelTimerSecs.AutoSize = true;
            this.LabelTimerSecs.BackColor = System.Drawing.Color.Transparent;
            this.LabelTimerSecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTimerSecs.Location = new System.Drawing.Point(81, 47);
            this.LabelTimerSecs.Name = "LabelTimerSecs";
            this.LabelTimerSecs.Size = new System.Drawing.Size(110, 24);
            this.LabelTimerSecs.TabIndex = 1;
            this.LabelTimerSecs.Text = "TimerSecs";
            this.LabelTimerSecs.Click += new System.EventHandler(this.label1_Click);
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
    }
}
