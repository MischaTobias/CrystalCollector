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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblSalir_MouseEnter(object sender, EventArgs e)
        {
            lblSalir.ForeColor = Color.Gray;
        }

        private void lblSalir_MouseLeave(object sender, EventArgs e)
        {
            lblSalir.ForeColor = Color.Black;
        }

        private void lblAcercaDe_MouseEnter(object sender, EventArgs e)
        {
            lblAcercaDe.ForeColor = Color.Gray;
        }

        private void lblAcercaDe_MouseLeave(object sender, EventArgs e)
        {
            lblAcercaDe.ForeColor = Color.Black;
        }

        private void btnIniciarNuevaPartida_Click(object sender, EventArgs e)
        {
            SeleccionPersonaje seleccion = new SeleccionPersonaje();
            seleccion.FormClosed += new FormClosedEventHandler(seleccion_FormClosed);
            seleccion.Show();
            this.Hide();
        }

        private void seleccion_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
