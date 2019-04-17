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
        PictureBox avatar = new PictureBox();
        int fila = 0;
        int columna = 0;

        public Form1()
        {
            this.KeyPreview = true;
            InitializeComponent();
            this.KeyUp += new KeyEventHandler(this.Form1_KeyDown);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerarPreguntas();
            GenerarAvatar();
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

        private void TableroDeJuego_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnTablero3x3_Click(object sender, EventArgs e)
        {
            CambiarColumnas(3);
            CambiarFilas(3);
        }

        private void BtnTablero4x5_Click(object sender, EventArgs e)
        {
            CambiarColumnas(4);
            CambiarFilas(5);
        }

        private void BtnTablero5x6_Click(object sender, EventArgs e)
        {
            CambiarColumnas(5);
            CambiarFilas(6);
        }

        private void BtnTablero6x7_Click(object sender, EventArgs e)
        {
            CambiarColumnas(6);
            CambiarFilas(7);
        }

        private void BtnTablero10x10_Click(object sender, EventArgs e)
        {
            CambiarColumnas(10);
            CambiarFilas(10);

        }

        public void CambiarFilas(int filas)
        {
            TableroDeJuego.SuspendLayout();
            TableroDeJuego.RowCount = filas;
            float height = 100 / filas;

            for (int i = 0; i < filas; i++)
            {
                if (TableroDeJuego.RowStyles.Count <= i)
                {
                    TableroDeJuego.RowStyles.Add(new RowStyle(SizeType.Percent));
                }
                TableroDeJuego.RowStyles[i].Height = height;
            }
            TableroDeJuego.ResumeLayout();
        }

        public void CambiarColumnas(int columnas)
        {
            TableroDeJuego.SuspendLayout();
            TableroDeJuego.ColumnCount = columnas;
            float width = 100 / columnas;

            for (int i = 0; i < columnas; i++)
            {
                if (TableroDeJuego.ColumnStyles.Count <= i)
                {
                    TableroDeJuego.ColumnStyles.Add(new ColumnStyle(SizeType.Percent));
                }
                TableroDeJuego.ColumnStyles[i].Width = width;
            }

            TableroDeJuego.ResumeLayout();
        }

        public void GenerarAvatar()
        {
            avatar.Image = global::InicioProyectoCrystalCollector.Properties.Resources.MaleWarrior;
            avatar.Dock = DockStyle.Fill;
            avatar.SizeMode = PictureBoxSizeMode.Zoom;
            TableroDeJuego.Controls.Add(avatar, columna, fila);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            TableroDeJuego.SuspendLayout();
            switch (e.KeyCode)
            { 
                case Keys.Left:
                case Keys.A:
                    if (columna != 0)
                    {
                        MoverAvatarIzquierda();
                    }
                    break;
                case Keys.Up:
                case Keys.W:
                    if (fila != 0)
                    {
                        MoverAvatarArriba();
                    }
                    break;
                case Keys.Right:
                case Keys.D:
                    if (columna < TableroDeJuego.ColumnCount-1)
                    {
                        MoverAvatarDerecha();
                    }
                    break;
                case Keys.Down:
                case Keys.S:
                    if (fila < TableroDeJuego.RowCount-1)
                    {
                        MoverAvatarAbajo();
                    }
                    break;
            }
            TableroDeJuego.ResumeLayout();
        }

        public void MoverAvatarAbajo()
        {
            TableroDeJuego.Controls.Remove(avatar);
            fila++;
            TableroDeJuego.Controls.Add(avatar, columna, fila);
        }

        public void MoverAvatarArriba()
        {
            TableroDeJuego.Controls.Remove(avatar);
            fila--;
            TableroDeJuego.Controls.Add(avatar, columna, fila);
        }

        public void MoverAvatarDerecha()
        {
            TableroDeJuego.Controls.Remove(avatar);
            columna++;
            TableroDeJuego.Controls.Add(avatar, columna, fila);
        }

        public void MoverAvatarIzquierda()
        {
            TableroDeJuego.Controls.Remove(avatar);
            columna--;
            TableroDeJuego.Controls.Add(avatar, columna, fila);
        }
    }
}
