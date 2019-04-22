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
        public delegate void CerrarStatusHandler(object sender);
        public event CerrarStatusHandler CerrarStatus;

        int posY;
        int rowcant;

        public EstadoAvatar()
        {

        }

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

        private void label5_Click(object sender, EventArgs e)
        {
            CerrarStatus.Invoke(this);
            this.Close();
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = Color.DarkGray;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.White;
        }

        private void CalcularY()
        {
            posY = rowcant - posY;
        }
    }
}
