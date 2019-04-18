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
        private Preguntas[] pr = new Preguntas[6];
        private PictureBox troll = new PictureBox();
        private int nivel = 3;

        Avatar jugador = new Avatar();
        Nivel lvl = new Nivel();

        public Form1()
        {
            this.KeyPreview = true;
            InitializeComponent();
            this.KeyUp += new KeyEventHandler(this.Form1_KeyDown);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            jugador.GeneroAvatar(0);
            VaciarPanelPreguntas();
            lvl = new Nivel(nivel, TableroDeJuego, jugador);
        }

        public void VaciarPanelPreguntas()
        {
            this.panelPreguntas1.LimpiarPanel();
        }

        public void GenerarPreguntas(int inicio)
        {
            int num;

            pr[0] = new Preguntas("", new string[3] { "", "", "" }, 4);
            pr[1] = new Preguntas("¿Quién escribió Romeo y Julieta?", new string[3] { "Shakespeare", "Leonardo Da Vinci", "Leonardo DiCaprio" }, 0);
            pr[2] = new Preguntas("¿Cuál de los siguientes es un número primo?", new string[3] { "21", "25", "17" }, 2);
            pr[3] = new Preguntas("¿En qué año se fundó la URL?", new string[3] { "1983", "1961", "1745" }, 1);
            pr[4] = new Preguntas("¿En qué año se estrenó el titanic?", new string[3] { "1997", "2000", "1985" }, 0);
            pr[5] = new Preguntas("¿Cuál es la operación correcta?", new string[3] { "2 + 2 = Pez", "5 x 5 = 120", "Raíz de 144 = 12" }, 2);

            if (inicio > 0)
            {
                Random numpregunta = new Random();
                num = numpregunta.Next(0, 4);
            }
            else
            {
                num = 0;
            }

            this.panelPreguntas1.AsignarPregunta(pr[num]);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            TableroDeJuego.SuspendLayout();
            switch (e.KeyCode)
            { 
                case Keys.Left:
                case Keys.A:
                    if (jugador.columnaactual != 0)
                    {
                        lvl.MoverIzquierda();
                    }
                    break;
                case Keys.Up:
                case Keys.W:
                    if (jugador.filaactual != 0)
                    {
                        lvl.MoverArriba();
                    }
                    break;
                case Keys.Right:
                case Keys.D:
                    if (jugador.columnaactual < TableroDeJuego.ColumnCount-1)
                    {
                        lvl.MoverDerecha();
                    }
                    break;
                case Keys.Down:
                case Keys.S:
                    if (jugador.filaactual < TableroDeJuego.RowCount-1)
                    {
                        lvl.MoverAbajo();
                    }
                    break;
            }
            TableroDeJuego.ResumeLayout();
        }
    }
}
