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
        /// <summary>
        /// Declaración de variables y eventos.
        /// </summary>
        private int tiempo;
        public int gemasrecogidas;

        public string nombre;
        public bool genero;
        public int cantvidas;
        public int puntos;
        public int x, y;
        public int rowcanttablero;

        EstadoAvatar estado = new EstadoAvatar();
        public Inicio inicio = new Inicio();

        public delegate void StatusAvatarHandler(object sender);
        public event StatusAvatarHandler ActualizarDatos;

        /// <summary>
        /// Constructor PanelStatusJuego, establece valores a variables locales.
        /// </summary>
        public PanelStatusJuego()
        {
            InitializeComponent();
            tiempo = 0;
            gemasrecogidas = 0;
            Num1.Text = gemasrecogidas.ToString();
            lblSecs.Text = "";
        }

        /// <summary>
        /// Procedimiento que lleva a cabo el procedimiento EmpezarTimer()
        /// </summary>
        /// <param name="sender"></param>
        private void CerrarStatus(object sender)
        {
            EmpezarTimer();
        }

        /// <summary>
        /// Procedimiento que lleva a cabo el procedimiento PararTimer()
        /// </summary>
        /// <param name="sender"></param>
        private void CerrarStatusFinal(object sender)
        {
            PararTimer();
        }

        /// <summary>
        /// Procedimiento que asigna una imagen a una pictureBox con base en una variable genero.
        /// </summary>
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

        /// <summary>
        /// Procedimiento que crea un nuevo form tipo EstadoAvatar y asigna un Handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxAvatar_Click(object sender, EventArgs e)
        {
            this.ActualizarDatos.Invoke(this);
            estado = new EstadoAvatar(nombre, genero, cantvidas, gemasrecogidas, puntos, x, y, tiempo, rowcanttablero);
            this.estado.CerrarStatus += new EstadoAvatar.CerrarStatusHandler(CerrarStatus);
            estado.Show();
        }

        /// <summary>
        /// Procedimiento que incrementa el tiempo en 1 por cada tick que el timer da. Además, asigna ese valor a un label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempo++;
            lblSecs.Text = tiempo.ToString();
        }

        /// <summary>
        /// Procedimiento que activa el timer.
        /// </summary>
        public void EmpezarTimer()
        {
            timer1.Enabled = true;
        }

        /// <summary>
        /// Procedimiento que desactiva el timer.
        /// </summary>
        public void PararTimer()
        {
            timer1.Enabled = false;
        }

        /// <summary>
        /// Procedimiento que cambia el valor de una label con base en una variable gemas.
        /// </summary>
        /// <param name="gemas"></param>
        public void EstablecerGemasNivel(int gemas)
        {
            Num2.Text = "of " + gemas;
        }

        /// <summary>
        /// Procedimiento que crea un nuevo form tipo EstadoAvatar y asigna un Handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.ActualizarDatos.Invoke(this);
            estado = new EstadoAvatar(nombre, genero, cantvidas, gemasrecogidas, puntos, x, y, tiempo, rowcanttablero);
            this.estado.CerrarStatus += new EstadoAvatar.CerrarStatusHandler(CerrarStatus);
            estado.Show();
        }

        /// <summary>
        /// Procedimiento que incrementa en 1 la variable gemas recogidas y asigna este valor a una label.
        /// </summary>
        public void AgregarGema()
        {
            gemasrecogidas++;
            Num1.Text = gemasrecogidas.ToString();
        }

        /// <summary>
        /// Procedimiento que asigna 0 a la variable gemas recogidas y asigna este valor a una label.
        /// </summary>
        public void GemasCero()
        {
            gemasrecogidas = 0;
            Num1.Text = gemasrecogidas.ToString();
        }

        /// <summary>
        /// Procedimiento que crea un nuevo form tipo EstadoAvatar y asigna un Handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void MostrarFinal()
        {
            this.ActualizarDatos.Invoke(this);
            estado = new EstadoAvatar(nombre, genero, cantvidas, gemasrecogidas, puntos, x, y, tiempo, rowcanttablero);
            this.estado.CerrarStatus += new EstadoAvatar.CerrarStatusHandler(CerrarStatusFinal);
            estado.Show();
        }
    }
}
