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

        /// <summary>
        /// Declaración de variables
        /// </summary>
        bool genero;

        /// <summary>
        /// Constructor SeleccionPersonaje, asigna valores a una variable local.
        /// </summary>
        public SeleccionPersonaje()
        {
            InitializeComponent();
            genero = true;
        }
        
        /// <summary>
        /// Procedimiento que cambia la imagen de una picture box con base en una variable genero.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Procedimiento que cambia la imagen de una picture box con base en una variable genero.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Procedimiento que crea un nuevo form del tipo form 1, además esconde este form y asigna un handler para un evento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            Form1 Juego = new Form1(txtNombre.Text, genero);
            Juego.FormClosed += new FormClosedEventHandler(JuegoClosed);
            Juego.Show();
            this.Hide();
        }

        /// <summary>
        /// Procedimiento que cierra este form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JuegoClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
