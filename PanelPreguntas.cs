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
        Preguntas pregunta = new Preguntas();
        int seleccionrespuesta = 0;

        public PanelPreguntas()
        {
            InitializeComponent();
        }

        private void PanelPreguntas_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        public void AsignarPregunta(Preguntas pregunta)
        {
            this.pregunta = pregunta;
            this.lblPregunta.Text = pregunta.pregunta;
            this.Respuesta1.Text = pregunta.respuestas[0];
            this.Respuesta2.Text = pregunta.respuestas[1];
            this.Respuesta3.Text = pregunta.respuestas[2];
        }

        public void Respuesta1_CheckedChanged(object sender, EventArgs e)
        {
            if (Respuesta1.Checked)
            {
                seleccionrespuesta = 0;
            }
        }

        public void Respuesta2_CheckedChanged(object sender, EventArgs e)
        {
            if (Respuesta2.Checked)
            {
                seleccionrespuesta = 1;
            }
        }

        public void Respuesta3_CheckedChanged(object sender, EventArgs e)
        {
            if (Respuesta3.Checked)
            {
                seleccionrespuesta = 2;
            }
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            bool resultado = pregunta.VerificarRespuesta(seleccionrespuesta);
            if (resultado)
            {
                MessageBox.Show("La respuesta es correcta", "Advertencia");
            }
            else
            {
                MessageBox.Show("La respuesta es incorrecta", "Advertencia");
            }
        }

        public void LimpiarPanel()
        {
            pictureBox1.Hide();
            panel3.Hide();
        }

        public void MostrarPanel()
        {
            pictureBox1.Show();
            panel3.Show();
        }
    }
}
