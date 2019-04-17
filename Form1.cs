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
    public partial class Form1 : Form
    {
        Preguntas[] pr = new Preguntas[5];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerarPreguntas();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void GenerarPreguntas()
        {
            pr[0] = new Preguntas("¿Quién escribió Romeo y Julieta?", new string[3] { "Shakespeare", "Leonardo Da Vinci", "Leonardo DiCaprio" }, 0);
            pr[1] = new Preguntas("¿Cuál de los siguientes es un número primo?", new string[3] { "21", "25", "17" }, 2);
            pr[2] = new Preguntas("¿En qué año se fundó la URL?", new string[3] { "1983", "1961", "1745" }, 1);
            pr[3] = new Preguntas("¿En qué año se estrenó el titanic?", new string[3] { "1997", "2000", "1985" }, 0);
            pr[4] = new Preguntas("¿Cuál es la operación correcta?", new string[3] { "2 + 2 = Pez", "5 x 5 = 120", "Raíz de 144 = 12" }, 2);

            Random numpregunta = new Random();
            int num = numpregunta.Next(0, 4);

            this.panelPreguntas1.AsignarPregunta(pr[num]);
        }
    }
}
