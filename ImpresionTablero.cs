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
        /// <summary>
        /// Declaración de variables y eventos.
        /// </summary>
        /// <param name="sender"></param>
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

        /// <summary>
        /// Constructor de ImpresionTablero
        /// </summary>
        public ImpresionTablero()
        {

        }

        /// <summary>
        /// Constructor con parámetros que asigna valores a las variables y lleva a cabo otros procedimientos.
        /// </summary>
        /// <param name="mapa"></param>
        /// <param name="filajugador"></param>
        /// <param name="columnajugador"></param>
        /// <param name="dificultad"></param>
        /// <param name="genero"></param>
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

        /// <summary>
        /// Dependiendo del nivel de dificultad, lleva a cabo procedimientos con distintos parámetros.
        /// </summary>
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

        /// <summary>
        /// Procedimiento que cambia el table layout panel con base a la cantidad de filas que envían como parámetro.
        /// </summary>
        /// <param name="filas"></param>
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

        /// <summary>
        /// Procedimiento que cambia el table layout panel con base a la cantidad de columnas que envían como parámetro.
        /// </summary>
        /// <param name="columnas"></param>
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

        /// <summary>
        /// Con base en la matriz de mapa, se generan diferentes picturebox en el table layout panel.
        /// </summary>
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

        /// <summary>
        /// Se añade una picturebox del avatar con base en la posición actual del jugador.
        /// </summary>
        private void GenerarAvatar()
        {
            jugador.GeneroAvatar();
            tLPMapa.Controls.Add(jugador.avatar, columnajugador, filajugador);
        }

        /// <summary>
        /// Procedimiento que genera una cierta cantidad de objetos tipo gema y los almacena en un vector; todo esto, con base en la dificultad.
        /// </summary>
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

        /// <summary>
        /// Procedimiento que cambia de color el label cuando el mouse entra a este.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblCerrar_MouseEnter(object sender, EventArgs e)
        {
            lblCerrar.ForeColor = Color.DarkGray;
        }

        /// <summary>
        /// Procedimiento que cambia de color el label cuando el mouse sale de este.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblCerrar_MouseLeave(object sender, EventArgs e)
        {
            lblCerrar.ForeColor = Color.White;
        }

        /// <summary>
        /// Procedimiento que cierra el form y causa el evento CerrarImpresión.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            CerrarImpresion.Invoke(this);
        }
    }
}
