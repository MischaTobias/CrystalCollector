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
    public partial class Instrucciones : Form
    {
        /// <summary>
        /// Constructor Instrucciones
        /// </summary>
        public Instrucciones()
        {

        }

        /// <summary>
        /// Constructor que ejecuta diferentes procedimientos en base a una variable booleana.
        /// </summary>
        /// <param name="var"></param>
        public Instrucciones(bool var)
        { 
            InitializeComponent();
            if (var)
            {
                CasoInstrucciones();
            }
            else
            {
                CasoAcercaDeCrystallCollector();
            }
        }

        /// <summary>
        /// Asigna valores string de "Instrucciones" a diferentes labels.
        /// </summary>
        private void CasoInstrucciones()
        {
            lblTitulo.Text = "Instrucciones";
            lblTexto.Text = 
                "El juego consiste en un Avatar que debe de moverse a lo largo de un tablero, el cual" +
                "\npodrá cambiar dependiendo el nivel que se encuentre jugando El objetivo principal" +
                "\ndel juego es recolectar cristales que se encuentran esparcidos por el tablero; el" +
                "\nAvatar podrá subir de nivel si y sólo si ha recolectado todos los cristales de " +
                "\ncada tablero. Dentro del tablero se encontrarán con varios obstáculos que pondrán" + 
                "\n a prueba a dicho Avatar.";
        }

        /// <summary>
        /// Asigna valores string de "Acerca de" a diferentes labels.
        /// </summary>
        private void CasoAcercaDeCrystallCollector()
        {
            lblTitulo.Text = "Acerca De:";
            lblTexto.Text = 
                "Este videojuego fue desarrollado por un estudiante del primero año de ingeniería de" +
                "\nla Universidad Rafael Landívar. El propósito de este proyecto es la comprensión de" +
                "\nclases, vectores y matrices a través de la creación de un videojuego a través del" +
                "\nentorno Visual Studio.";
        }

        /// <summary>
        /// Procedimiento que cierra este form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Procedimiento que cambia el color de una label a gris.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblCerrarVentana_MouseEnter(object sender, EventArgs e)
        {
            lblCerrarVentana.ForeColor = Color.DarkGray;
        }

        /// <summary>
        /// Procedimiento que cambia el color de una label a blanco.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblCerrarVentana_MouseLeave(object sender, EventArgs e)
        {
            lblCerrarVentana.ForeColor = Color.White;
        }
    }
}
