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
        Random x = new Random();

        // Incluimos los elementos del nivel
        Trolls[] trolls = new Trolls[2];
        Gemas[] gemas = new Gemas[4];
        Portal portal;
        Avatar jugador = new Avatar();
        Tablero tablero = new Tablero();
        int[] ProxPosicion = new int[2];

        // Hacemos un mapa del nivel
        public string[,] mapa = new string[3, 3];

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
            this.GenerarPortal();
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
            if (cantidad > 0)
            {
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
        }

        public void GenerarGemas()
        {
            int cantidad = (dificultad * 2) + 2;
            gemas = new Gemas[cantidad];

            for (int i = 0; i < gemas.Length; i++)
            {
                Gemas newGema = new Gemas();
                gemas[i] = newGema;
                PosicionGema(newGema);
            }
        }

        public void GenerarPortal()
        {
            portal = new Portal();
            PosicionPortal(portal);
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
            troll.Coordenadas[0] = posX;
            troll.Coordenadas[1] = posY;
            tablero.Controls.Add(troll.troll, posX, posY);
        }

        private void PosicionGema(Gemas gema)
        {
            int posX, posY;

            if (dificultad == 1)
            {
                do
                {
                    posX = x.Next(0, tablero.RowCount);
                    posY = x.Next(0, tablero.ColumnCount);
                }
                while (mapa[posX, posY] != null);
            }
            else
            {
                do
                {
                    posX = x.Next(0, tablero.RowCount - 1);
                    posY = x.Next(0, tablero.ColumnCount - 1);
                }
                while (mapa[posX, posY] != null);
            }

            mapa[posX, posY] = "Gema";
            tablero.Controls.Add(gema.gema, posX, posY);
        }

        /*
        private bool NoHayGema(int posX, int posY)
        {
            int sig1 = posX + 1;
            int sig2 = posX - 1;
            int sig3 = posY + 1;
            int sig4 = posY - 1;

            int res;
            res = SePuedeMover(posX, sig3);
            if (res == 2 || res == -1)
            {
                return false;
            }
            res = SePuedeMover(posX, sig4);
            if (res == 2 || res == -1)
            {
                return false;
            }
            res = SePuedeMover(sig1, posY);
            if (res == 2 || res == -1)
            {
                return false;
            }
            res = SePuedeMover(sig1, sig3);
            if (res == 2 || res == -1)
            {
                return false;
            }
            res = SePuedeMover(sig1, sig4);
            if (res == 2 || res == -1)
            {
                return false;
            }
            res = SePuedeMover(sig2, posY);
            if (res == 2 || res == -1)
            {
                return false;
            }
            res = SePuedeMover(sig2, sig3);
            if (res == 2 || res == -1)
            {
                return false;
            }
            res = SePuedeMover(sig2, sig4);
            if (res == 2 || res == -1)
            {
                return false;
            }
            return true;
        }
        */

        private void PosicionPortal(Portal portal)
        {
            int posX, posY;

            if (dificultad == 1)
            {
                do
                {
                    posX = x.Next(0, tablero.RowCount);
                    posY = x.Next(0, tablero.ColumnCount);
                }
                while (mapa[posX, posY] != null);
            }
            else
            {
                do
                {
                    posX = x.Next(0, tablero.RowCount - 1);
                    posY = x.Next(0, tablero.ColumnCount - 1);
                }
                while (mapa[posX, posY] != null);
            }

            mapa[posX, posY] = "Portal";
            portal.Coordenadas[0] = posX;
            portal.Coordenadas[1] = posY;
            tablero.Controls.Add(portal.portal, posX, posY);
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
            else if (mapa[x,y] == "Portal")
            {
                return 3;
            }
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
                return 2;
            }

            if (res == 3)
            {
                ProxPosicion[0] = jugador.columnaactual;
                ProxPosicion[1] = jugador.filaactual + 1;
                return 3;
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
                ProxPosicion[0] = jugador.columnaactual;
                ProxPosicion[1] = jugador.filaactual + 1;

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
                return 2;
            }

            if (res == 3)
            {
                ProxPosicion[0] = jugador.columnaactual;
                ProxPosicion[1] = jugador.filaactual - 1;
                return 3;
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
                ProxPosicion[0] = jugador.columnaactual;
                ProxPosicion[1] = jugador.filaactual - 1;
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
                return 2;
            }

            if (res == 3)
            {
                ProxPosicion[0] = jugador.columnaactual + 1;
                ProxPosicion[1] = jugador.filaactual;
                return 3;
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
                ProxPosicion[0] = jugador.columnaactual + 1;
                ProxPosicion[1] = jugador.filaactual;
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
                return 2;
            }

            if (res == 3)
            {
                ProxPosicion[0] = jugador.columnaactual - 1;
                ProxPosicion[1] = jugador.filaactual;
                return 3;
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
                ProxPosicion[0] = jugador.columnaactual - 1;
                ProxPosicion[1] = jugador.filaactual;
                return 0;
            }
            return 2;
        }

        public void RemoverGema(int x, int y)
        {
            tablero.Controls.Remove(tablero.GetControlFromPosition(x, y));
            jugador.CambiarPunteo(5);
            tablero.Controls.Remove(jugador.avatar);
            tablero.Controls.Add(jugador.avatar, x, y);
            jugador.filaactual = y;
            jugador.columnaactual = x;
            mapa[x, y] = "Avatar";
        }

        public Trolls EncontrarTroll(int x, int y)
        {
            Trolls troll;
            for (int i = 0; i < trolls.Length; i++)
            {
                troll = trolls[i];
                if (troll.Coordenadas[0] == x && troll.Coordenadas[1] == y)
                {
                    return troll;
                }
            }
            return null;
        }

        public void MoverTroll()
        {
            tablero.SuspendLayout();
            tablero.Controls.Remove(tablero.GetControlFromPosition(ProxPosicion[0], ProxPosicion[1]));
            PosicionTroll(EncontrarTroll(ProxPosicion[0], ProxPosicion[1]));

            tablero.Controls.Remove(jugador.avatar);
            tablero.Controls.Add(jugador.avatar, ProxPosicion[0], ProxPosicion[1]);
            jugador.filaactual = ProxPosicion[1];
            jugador.columnaactual = ProxPosicion[0];
            mapa[ProxPosicion[0], ProxPosicion[1]] = "Avatar";
            tablero.ResumeLayout();
        }

        public void MoverPortal()
        {
            tablero.SuspendLayout();
            tablero.Controls.Remove(tablero.GetControlFromPosition(ProxPosicion[0], ProxPosicion[1]));
            PosicionPortal(portal);

            tablero.Controls.Remove(jugador.avatar);
            tablero.Controls.Add(jugador.avatar, ProxPosicion[0], ProxPosicion[1]);
            jugador.filaactual = ProxPosicion[1];
            jugador.columnaactual = ProxPosicion[0];
            mapa[ProxPosicion[0], ProxPosicion[1]] = "Avatar";
            tablero.ResumeLayout();
        }
    }
}
