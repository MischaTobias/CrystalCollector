using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicioProyectoCrystalCollector
{
    class Nivel
    {
        // Generaremos los numeros aleatorios
        Random x = new Random(50);

        // Incluimos los elementos del nivel
        Trolls[] trolls = new Trolls[2];
        Gemas[] gemas = new Gemas[4];
        Avatar jugador = new Avatar();
        Tablero tablero = new Tablero();

        // Hacemos un mapa del nivel
        string[,] mapa = new string[3, 3];

        int dificultad = 1;
        public Nivel()
        {

        }

        public Nivel(int dificultad, Tablero tablero, Avatar avatar)
        {
            this.dificultad = dificultad;
            this.tablero = tablero;
            this.jugador = avatar;

            this.LlenarMatriz();
            this.tablero.CambiarTablero(this.dificultad);
            this.GenerarAvatarRandom();
            this.GenerarTrolls();
            this.GenerarGemas();
        }

        public void LlenarMatriz()
        {
            switch (this.dificultad)
            {
                case 1:
                    mapa = new string[3, 3];
                    break;
                case 2:
                    mapa = new string[4, 5];
                    break;
                case 3:
                    mapa = new string[5, 6];
                    break;
                case 4:
                    mapa = new string[6, 7];
                    break;
                case 5:
                    mapa = new string[10, 10];
                    break;
            }
        }

        public void GenerarTablero()
        {
            tablero.CambiarTablero(dificultad);
        }

        /// <summary>
        /// Genera el avatar de forma Aleatoria
        /// </summary>
        public void GenerarAvatarRandom()
        {
            int posX = 1, posY = 1;
            if (this.dificultad > 1)
            {
                posX = x.Next(0, tablero.RowCount - 1);
                posY = x.Next(0, tablero.ColumnCount - 1);
            }
            this.tablero.Controls.Add(this.jugador.avatar, posX, posY);
            mapa[posX, posY] = "Avatar";
            jugador.columnaactual = posX;
            jugador.filaactual = posY;
        }

        public void GenerarTrolls()
        {
            int cantidad = (dificultad - 2) * 2 + 2;
            switch (dificultad)
            {
                case 1:
                    break;
                default:
                    trolls = new Trolls[cantidad];
                    break;
            }

            for (int i = 0; i < trolls.Length; i++)
            {
                Trolls newTroll = new Trolls();
                trolls[i] = newTroll;
                PosicionTroll(newTroll);
            }
        }

        public void GenerarGemas()
        {
            int cantidad = (dificultad * 2) + 2;
            gemas = new Gemas[cantidad];

            for (int i = 0; i < trolls.Length; i++)
            {
                Gemas newGema = new Gemas();
                gemas[i] = newGema;
                PosicionGema(newGema);
            }
        }

        private void PosicionTroll(Trolls troll)
        {
            int posX, posY;

            do
            {
                posX = x.Next(0, tablero.RowCount - 1);
                posY = x.Next(0, tablero.ColumnCount - 1);
            }
            while (mapa[posX, posY] != null);

            mapa[posX, posY] = "Troll";
            tablero.Controls.Add(troll.troll, posX, posY);
        }

        private void PosicionGema(Gemas gema)
        {
            int posX, posY;

            do
            {
                posX = x.Next(0, tablero.RowCount - 1);
                posY = x.Next(0, tablero.ColumnCount - 1);
            }
            while (mapa[posX, posY] != null);

            mapa[posX, posY] = "Gema";
            tablero.Controls.Add(gema.gema, posX, posY);
        }

        public int SePuedeMover(int x, int y)
        {
            if (x < 0 || x > tablero.RowCount || y < 0 || y > tablero.ColumnCount)
            {
                return -1;
            }
            else if (mapa[x,y] == "Troll")
            {
                return 0;
            }
            else if (mapa[x,y] == "Gema")
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }

        public int MoverAbajo()
        {
            int res = SePuedeMover(jugador.columnaactual, jugador.filaactual + 1);

            if (res == 2)
            {
                RemoverGema(jugador.columnaactual, jugador.filaactual + 1);
            }

            if (res > 0)
            {
                tablero.Controls.Remove(jugador.avatar);
                jugador.filaactual++;
                tablero.Controls.Add(jugador.avatar, jugador.columnaactual, jugador.filaactual);
                return 1;
            }
            else if (res == 0)
            {
                //PanelPreguntasShow()
                tablero.Controls.Remove(tablero.GetControlFromPosition(jugador.columnaactual, jugador.filaactual + 1));
                mapa[jugador.columnaactual, jugador.filaactual + 1] = null;
                return 0;
            }
            return 2;
        }

        public int MoverArriba()
        {
            int res = SePuedeMover(jugador.columnaactual, jugador.filaactual - 1);

            if (res == 2)
            {
                RemoverGema(jugador.columnaactual, jugador.filaactual - 1);
            }

            if (res > 0)
            {
                tablero.Controls.Remove(jugador.avatar);
                jugador.filaactual--;
                tablero.Controls.Add(jugador.avatar, jugador.columnaactual, jugador.filaactual);
                return 1;
            }
            else if (res == 0)
            {
                tablero.Controls.Remove(tablero.GetControlFromPosition(jugador.columnaactual, jugador.filaactual - 1));
                mapa[jugador.columnaactual, jugador.filaactual - 1] = null;
                return 0;
            }
            return 2;
        }

        public int MoverDerecha()
        {
            int res = SePuedeMover(jugador.columnaactual + 1, jugador.filaactual);

            if (res == 2)
            {
                RemoverGema(jugador.columnaactual + 1, jugador.filaactual);
            }

            if (res > 0)
            {
                tablero.Controls.Remove(jugador.avatar);
                jugador.columnaactual++;
                tablero.Controls.Add(jugador.avatar, jugador.columnaactual, jugador.filaactual);
                return 1;
            }
            else if (res == 0)
            {
                tablero.Controls.Remove(tablero.GetControlFromPosition(jugador.columnaactual + 1, jugador.filaactual));
                mapa[jugador.columnaactual + 1, jugador.filaactual] = null;
                return 0;
            }
            return 2;
        }

        public int MoverIzquierda()
        {
            int res = SePuedeMover(jugador.columnaactual - 1, jugador.filaactual);

            if (res == 2)
            {
                RemoverGema(jugador.columnaactual - 1, jugador.filaactual);
            }

            if (res > 0)
            {
                tablero.Controls.Remove(jugador.avatar);
                jugador.columnaactual--;
                tablero.Controls.Add(jugador.avatar, jugador.columnaactual, jugador.filaactual);
                return 1;
            }
            else if (res == 0)
            {
                tablero.Controls.Remove(tablero.GetControlFromPosition(jugador.columnaactual - 1, jugador.filaactual));
                mapa[jugador.columnaactual - 1, jugador.filaactual] = null;
                return 0;
            }
            return 2;
        }

        public void RemoverGema(int x, int y)
        {
            tablero.Controls.Remove(tablero.GetControlFromPosition(x, y));
            jugador.CambiarPunteo(5);
            mapa[x, y] = null;
        }
    }
}
