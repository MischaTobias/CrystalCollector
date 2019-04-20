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

        public string nombre;
        public bool genero;
        public int cantvidas;
        public int puntos;
        public int x, y;
        EstadoAvatar estado = new EstadoAvatar();
        public Inicio inicio = new Inicio();

        public delegate void StatusAvatarHandler(object sender);
        public event StatusAvatarHandler ActualizarDatos;

        public delegate void TerminarPartidaHandler(object sender);
        public event TerminarPartidaHandler TerminarPartida;


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

        private void CerrarStatus(object sender)
        {
            EmpezarTimer();
        }

        public void SetAvatar()
        {
            if (genero)
            {
                PictureBoxAvatar.Image = global::InicioProyectoCrystalCollector.Properties.Resources.MaleWarrior;
                genero = false;
            }
            else
            {
                PictureBoxAvatar.Image = global::InicioProyectoCrystalCollector.Properties.Resources.FemaleWarrior;
                genero = true;
            }
        }

        private void PictureBoxAvatar_Click(object sender, EventArgs e)
        {
            this.ActualizarDatos.Invoke(this);
            estado = new EstadoAvatar(nombre, genero, cantvidas, gemasrecogidas, puntos, x, y, tiempo);
            this.estado.CerrarStatus += new EstadoAvatar.CerrarStatusHandler(CerrarStatus);
            estado.Show();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.ActualizarDatos.Invoke(this);
            estado = new EstadoAvatar(nombre, genero, cantvidas, gemasrecogidas, puntos, x, y, tiempo);
            this.estado.CerrarStatus += new EstadoAvatar.CerrarStatusHandler(CerrarStatus);
            estado.Show();
        }

        public void AgregarGema()
        {
            gemasrecogidas++;
            Num1.Text = gemasrecogidas.ToString();
        }
    }
}
