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
    public partial class PanelPreguntas : UserControl
    {
        /// <summary>
        /// Declaración de variables y eventos.
        /// </summary>
        Preguntas pregunta = new Preguntas();
        int seleccionrespuesta = 0;
        bool resultado;

        public delegate void PreguntaRespondidaHandler(object sender, bool result);
        public event PreguntaRespondidaHandler PreguntaRespondida;

        public delegate void CambiarPreguntaHandler(object sender);
        public event CambiarPreguntaHandler CambiarPregunta;

        /// <summary>
        /// Constructor PanelPreguntas
        /// </summary>
        public PanelPreguntas()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Procedimiento que asigna valores a labels con base en una pregunta.
        /// </summary>
        /// <param name="pregunta"></param>
        public void AsignarPregunta(Preguntas pregunta)
        {
            this.pregunta = pregunta;
            this.lblPregunta.Text = pregunta.pregunta;
            this.Respuesta1.Text = pregunta.respuestas[0];
            this.Respuesta2.Text = pregunta.respuestas[1];
            this.Respuesta3.Text = pregunta.respuestas[2];
        }

        /// <summary>
        /// Procedimiento que cambia el valor de la respuesta seleccionada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Respuesta1_CheckedChanged(object sender, EventArgs e)
        {
            if (Respuesta1.Checked)
            {
                seleccionrespuesta = 0;
            }
        }

        /// <summary>
        /// Procedimiento que cambia el valor de la respuesta seleccionada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Respuesta2_CheckedChanged(object sender, EventArgs e)
        {
            if (Respuesta2.Checked)
            {
                seleccionrespuesta = 1;
            }
        }

        /// <summary>
        /// Procedimiento que cambia el valor de la respuesta seleccionada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Respuesta3_CheckedChanged(object sender, EventArgs e)
        {
            if (Respuesta3.Checked)
            {
                seleccionrespuesta = 2;
            }
        }

        /// <summary>
        /// Procedimiento que lleva a cabo un evento PreguntaRespondida y asigna un valor a resultado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResponder_Click(object sender, EventArgs e)
        {
            resultado = pregunta.VerificarRespuesta(seleccionrespuesta);
            /*
            if (resultado)
            {
                MessageBox.Show("La respuesta es correcta", "Advertencia");
            }
            else
            {
                MessageBox.Show("La respuesta es incorrecta", "Advertencia");
            }
            */
            this.PreguntaRespondida.Invoke(this, resultado);
        }

        /// <summary>
        /// Procedimiento que lleva a cabo un evento CambiarPregunta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCambiarPregunta_Click(object sender, EventArgs e)
        {
            this.CambiarPregunta.Invoke(this);
        }

        /// <summary>
        /// Procedimiento que cambia la disponibilidad de un botón con base en una variable estado.
        /// </summary>
        /// <param name="estado"></param>
        public void CambiarDisponibilidadBtnCambiar(bool estado)
        {
            btnCambiarPregunta.Enabled = estado;
        }
    }
}
