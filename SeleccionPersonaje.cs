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
    public partial class SeleccionPersonaje : Form
    {
        bool genero;

        public SeleccionPersonaje()
        {
            InitializeComponent();
            genero = true;
        }

        private void pBCambiarPersonaje_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();
            if (genero)
            {
                pBPersonaje.Image = global::InicioProyectoCrystalCollector.Properties.Resources.FemaleWarrior;
                genero = false;
            }
            else
            {
                pBPersonaje.Image = global::InicioProyectoCrystalCollector.Properties.Resources.MaleWarrior;
                genero = true;
            }
            this.ResumeLayout();
        }

        private void pbCambiarPersonajeReves_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();
            if (genero)
            {
                pBPersonaje.Image = global::InicioProyectoCrystalCollector.Properties.Resources.FemaleWarrior;
                genero = false;
            }
            else
            {
                pBPersonaje.Image = global::InicioProyectoCrystalCollector.Properties.Resources.MaleWarrior;
                genero = true;
            }
            this.ResumeLayout();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            Form1 Juego = new Form1(txtNombre.Text, genero);
            Juego.FormClosed += new FormClosedEventHandler(JuegoClosed);
            Juego.Show();
            this.Hide();
        }

        private void JuegoClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
