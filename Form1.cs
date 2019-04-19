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
        private int nivel = 5;
        private bool Freeze = false;
        private int ContadorPreguntas = 0;
        private int cantidadgemas;

        Avatar jugador = new Avatar();
        Nivel lvl = new Nivel();

        public Form1()
        {
            this.KeyPreview = true;
            InitializeComponent();
            this.KeyUp += new KeyEventHandler(this.Form1_KeyDown);
            this.panelPreguntas1.PreguntaRespondida += new PanelPreguntas.PreguntaRespondidaHandler(this.PreguntaRespondida);
            this.panelPreguntas1.CambiarPregunta += new PanelPreguntas.CambiarPreguntaHandler(this.CambiarPregunta);

            this.panelStatusJuego1.EmpezarTimer();
            EstablecerGemasNivel();
            this.panelStatusJuego1.EstablecerGemasNivel(cantidadgemas);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            jugador.GeneroAvatar(0);
            VaciarPanelPreguntas();
            lvl = new Nivel(nivel, TableroDeJuego, jugador);
        }

        public void VaciarPanelPreguntas()
        {
            this.panelPreguntas1.Hide();
        }

        public void MostrarPanelPreguntas()
        {
            this.panelPreguntas1.Show();
            GenerarPreguntas();
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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Freeze)
            {
                return;
            }
            TableroDeJuego.SuspendLayout();
            switch (e.KeyCode)
            { 
                case Keys.Left:
                case Keys.A:
                    if (jugador.columnaactual != 0)
                    {
                        switch (lvl.MoverIzquierda())
                        {
                            case 0:
                                MostrarPanelPreguntas();
                                Freeze = true;
                                this.panelStatusJuego1.PararTimer();
                                break;
                            case 2:
                                this.panelStatusJuego1.AgregarGema();
                                break;
                        }
                    }
                    break;
                case Keys.Up:
                case Keys.W:
                    if (jugador.filaactual != 0)
                    {
                        switch (lvl.MoverArriba())
                        {
                            case 0:
                                MostrarPanelPreguntas();
                                Freeze = true;
                                this.panelStatusJuego1.PararTimer();
                                break;
                            case 2:
                                this.panelStatusJuego1.AgregarGema();
                                break;
                        }
                    }
                    break;
                case Keys.Right:
                case Keys.D:
                    if (jugador.columnaactual < TableroDeJuego.ColumnCount-1)
                    {
                        switch (lvl.MoverDerecha())
                        {
                            case 0:
                                MostrarPanelPreguntas();
                                Freeze = true;
                                this.panelStatusJuego1.PararTimer();
                                break;
                            case 2:
                                this.panelStatusJuego1.AgregarGema();
                                break;
                        }
                    }
                    break;
                case Keys.Down:
                case Keys.S:
                    if (jugador.filaactual < TableroDeJuego.RowCount-1)
                    {
                        switch (lvl.MoverAbajo())
                        {
                            case 0:
                                MostrarPanelPreguntas();
                                Freeze = true;
                                this.panelStatusJuego1.PararTimer();
                                break;
                            case 2:
                                this.panelStatusJuego1.AgregarGema();
                                break;
                        }
                    }
                    break;
            }
            TableroDeJuego.ResumeLayout();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void panelPreguntas1_Load(object sender, EventArgs e)
        {
            
        }

        private void PreguntaRespondida(object sender, bool resultado)
        {
            Freeze = false;
            VaciarPanelPreguntas();
            ContadorPreguntas = 0;

            if (resultado)
            {
                lvl.MoverTroll();
            }
        }

        private void CambiarPregunta(object sender)
        {
            ContadorPreguntas++;
            Random numpregunta = new Random();
            int num = numpregunta.Next(0, 4);
            if (ContadorPreguntas<=3)
            {
                this.panelPreguntas1.AsignarPregunta(pr[num]);
            }
            else
            {
                MessageBox.Show("Ya no puede cambiar su pregunta, responda.", "ADVERTENCIA");
            }
        }

        private void EstablecerGemasNivel()
        {
            cantidadgemas = (nivel * 2) + 2;
        }
    }
}
