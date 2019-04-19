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
        public EstadoAvatar(string nombre, bool genero, int cantvidas, int cantjoyas, int puntos, int x, int y, int tiempo)
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
            this.lblPosicion.Text = "> (" + x.ToString() + ", " + y.ToString() + ")";
            this.lblTiempo.Text = "> " + tiempo.ToString() + " Segundos";
        }
    }
}
