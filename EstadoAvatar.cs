using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InicioProyectoCrystalCollector
{
    public partial class EstadoAvatar : Form
    {
        /// <summary>
        /// Se crea un evento para utilizarse cuando se cierre el form.
        /// </summary>
        /// <param name="sender"></param>
        public delegate void CerrarStatusHandler(object sender);
        public event CerrarStatusHandler CerrarStatus;

        /// <summary>
        /// Se establecen variables para utilizarlas en el cálculo de la posición del personaje.
        /// </summary>
        int posY;
        int rowcant;

        /// <summary>
        /// Constructor EstadoAvatar para crear objetos sin necesidad de parámetros.
        /// </summary>
        public EstadoAvatar()
        {

        }

        /// <summary>
        /// Constructor para poder asignar valores a diferentes labels e imágenes.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="genero"></param>
        /// <param name="cantvidas"></param>
        /// <param name="cantjoyas"></param>
        /// <param name="puntos"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="tiempo"></param>
        /// <param name="rowcant"></param>
        public EstadoAvatar(string nombre, bool genero, int cantvidas, int cantjoyas, int puntos, int x, int y, int tiempo, int rowcant)
        {
            InitializeComponent();
            this.lblNombre.Text = "> " + nombre;
            if (genero)
            {
                this.lblGenero.Text = "> Masculino";
                pBPersonaje.Image = global::InicioProyectoCrystalCollector.Properties.Resources.MaleWarrior;
            }
            else
            {
                this.lblGenero.Text = "> Femenino";
                pBPersonaje.Image = global::InicioProyectoCrystalCollector.Properties.Resources.FemaleWarrior;
            }
            this.lblVidas.Text = "> " + cantvidas.ToString();
            this.lblCristalesCaja.Text = "> " + cantjoyas.ToString();
            this.lblPuntos.Text = "> " + puntos.ToString();
            this.posY = y;
            this.rowcant = rowcant;
            CalcularY();
            this.lblPosicion.Text = "> (" + (x).ToString() + ", " + (posY-1).ToString() + ")";
            this.lblTiempo.Text = "> " + tiempo.ToString() + " Segundos";
            this.ControlBox = false;
        }

        /// <summary>
        /// Procedimiento que causa el evento creado anteriormente y luego cierra el form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label5_Click(object sender, EventArgs e)
        {
            CerrarStatus.Invoke(this);
            this.Close();
        }

        /// <summary>
        /// Procedimiento que cambia el color del label cuando el Mouse entra en ella.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = Color.DarkGray;
        }

        /// <summary>
        /// Procedimiento que cambia el color del label cuando el Mouse sale de ella.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.White;
        }

        /// <summary>
        /// Procedimiento para calcular la posición en Y como coordenada.
        /// </summary>
        private void CalcularY()
        {
            posY = rowcant - posY;
        }
    }
}
