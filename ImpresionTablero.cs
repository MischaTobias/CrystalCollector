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
    public partial class ImpresionTablero : Form
    {
        public delegate void CerrarImpresionHandler(object sender);
        public event CerrarImpresionHandler CerrarImpresion;

        string[,] mapa;
        Gemas[] gemas = new Gemas[3];
        Avatar jugador = new Avatar();
        Portal portal;
        int dificultad;
        int filajugador;
        int columnajugador;
        int contgema = 0;
        bool genero;

        public ImpresionTablero()
        {

        }

        public ImpresionTablero(string[,] mapa, int filajugador, int columnajugador, int dificultad, bool genero)
        {
            InitializeComponent();
            this.mapa = mapa;
            this.filajugador = filajugador;
            this.columnajugador = columnajugador;
            this.dificultad = dificultad;
            this.genero = genero;
            CambiarTablero();
            GenerarGemas();
            LlenarDataGrid();
            GenerarAvatar();
        }

        public void CambiarTablero()
        {
            switch (dificultad)
            {
                case 1:
                    CambiarColumnas(3);
                    CambiarFilas(3);
                    break;
                case 2:
                    CambiarColumnas(4);
                    CambiarFilas(5);
                    break;
                case 3:
                    CambiarColumnas(5);
                    CambiarFilas(6);
                    break;
                case 4:
                    CambiarColumnas(6);
                    CambiarFilas(7);
                    break;
                case 5:
                    CambiarColumnas(10);
                    CambiarFilas(10);
                    break;
            }
        }

        public void CambiarFilas(int filas)
        {
            tLPMapa.SuspendLayout();
            tLPMapa.RowCount = filas;
            float height = 100 / filas;

            for (int i = 0; i < filas; i++)
            {
                if (tLPMapa.RowStyles.Count <= i)
                {
                    tLPMapa.RowStyles.Add(new RowStyle(SizeType.Percent));
                }
                tLPMapa.RowStyles[i].Height = height;
            }
            tLPMapa.ResumeLayout();
        }

        public void CambiarColumnas(int columnas)
        {
            tLPMapa.SuspendLayout();
            tLPMapa.ColumnCount = columnas;
            float width = 100 / columnas;

            for (int i = 0; i < columnas; i++)
            {
                if (tLPMapa.ColumnStyles.Count <= i)
                {
                    tLPMapa.ColumnStyles.Add(new ColumnStyle(SizeType.Percent));
                }
                tLPMapa.ColumnStyles[i].Width = width;
            }

            tLPMapa.ResumeLayout();
        }

        private void LlenarDataGrid()
        {
            for (int i = 0; i < mapa.GetLength(0); i++)
            {
                for (int j = 0; j < mapa.GetLength(1); j++)
                {
                    if (mapa[i,j] == "Gema")
                    {
                        tLPMapa.Controls.Add(gemas[contgema].gema, i, j);
                        contgema++;
                    }
                    else if (mapa[i,j] == "Portal")
                    {
                        portal = new Portal();
                        tLPMapa.Controls.Add(portal.portal, i, j);
                    }
                }
            }
        }

        private void GenerarAvatar()
        {
            jugador.GeneroAvatar(genero);
            tLPMapa.Controls.Add(jugador.avatar, columnajugador, filajugador);
        }

        public void GenerarGemas()
        {
            int cantidad = (dificultad * 2) + 2;
            gemas = new Gemas[cantidad];

            for (int i = 0; i < gemas.Length; i++)
            {
                Gemas newGema = new Gemas();
                gemas[i] = newGema;
            }
        }

        private void lblCerrar_MouseEnter(object sender, EventArgs e)
        {
            lblCerrar.ForeColor = Color.DarkGray;
        }

        private void lblCerrar_MouseLeave(object sender, EventArgs e)
        {
            lblCerrar.ForeColor = Color.White;
        }
        /*
        private void lblCerrar_Click(object sender, EventArgs e)
        {
            //CerrarImpresion.Invoke(this);
            this.Close();
        }
        */

        private void lblCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            CerrarImpresion.Invoke(this);
        }
    }
}
