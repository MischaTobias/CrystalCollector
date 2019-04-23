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
        /// <summary>
        /// Constructor Inicio.
        /// </summary>
        public Inicio()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Procedimiento que cierra este form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Procedimiento que cambia el color del label cuando el mouse entra en contacto con él.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblSalir_MouseEnter(object sender, EventArgs e)
        {
            lblSalir.ForeColor = Color.Gray;
        }

        /// <summary>
        /// Procedimiento que cambia el color del label cuando el mouse deja de estar en contacto con él.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblSalir_MouseLeave(object sender, EventArgs e)
        {
            lblSalir.ForeColor = Color.Black;
        }

        /// <summary>
        /// Procedimiento que cambia el color del label cuando el mouse entra en contacto con él.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblAcercaDe_MouseEnter(object sender, EventArgs e)
        {
            lblAcercaDe.ForeColor = Color.Gray;
        }

        /// <summary>
        /// Procedimiento que cambia el color del label cuando el mouse deja de estar en contacto con él.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblAcercaDe_MouseLeave(object sender, EventArgs e)
        {
            lblAcercaDe.ForeColor = Color.Black;
        }

        /// <summary>
        /// Procedimiento que crea un nuevo form del tipo selección personaje y que esconde este form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIniciarNuevaPartida_Click(object sender, EventArgs e)
        {
            SeleccionPersonaje seleccion = new SeleccionPersonaje();
            seleccion.FormClosed += new FormClosedEventHandler(seleccion_FormClosed);
            seleccion.Show();
            this.Hide();
        }

        /// <summary>
        /// Procedimiento que cierra este form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void seleccion_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
