using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InicioProyectoCrystalCollector
{
    public partial class PanelStatusJuego : UserControl
    {
        private int tiempo;
        public int gemasrecogidas;

        public PanelStatusJuego()
        {
            InitializeComponent();
            tiempo = 0;
            gemasrecogidas = 0;
            Num1.Text = gemasrecogidas.ToString();
            lblSecs.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBoxAvatar_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempo++;
            lblSecs.Text = tiempo.ToString();
        }

        public void EmpezarTimer()
        {
            timer1.Enabled = true;
        }

        public void PararTimer()
        {
            timer1.Enabled = false;
        }

        public void EstablecerGemasNivel(int gemas)
        {
            Num2.Text = "of " + gemas;
        }

        public void AgregarGema()
        {
            gemasrecogidas++;
            Num1.Text = gemasrecogidas.ToString();
        }
    }
}
