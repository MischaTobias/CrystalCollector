using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicioProyectoCrystalCollector
{
    class Nivel
    {
        /// <summary>
        /// Declaración de variables
        /// </summary>
        Random x = new Random();

        Trolls[] trolls = new Trolls[2];
        Gemas[] gemas = new Gemas[4];
        Portal portal;
        Avatar jugador = new Avatar();
        Tablero tablero = new Tablero();
        int[] ProxPosicion = new int[2];
        public int contgemas = 0;

        public string[,] mapa = new string[3, 3];
        int dificultad = 1;

        /// <summary>
        /// ConstructorNivel
        /// </summary>
        public Nivel()
        {

        }

        /// <summary>
        /// Constructor nivel que asigna a valores a las diferentes variables y lleva a cabo otros procedimientos.
        /// </summary>
        /// <param name="dificultad"></param> Recibe un int para establecer el valor de la variable local "dificultad".
        /// <param name="tablero"></param> 
        /// <param name="avatar"></param>
        public Nivel(int dificultad, Tablero tablero, Avatar avatar)
        {
            this.dificultad = dificultad;
            this.tablero = tablero;
            this.jugador = avatar;

            LlenarMatriz();
            this.tablero.CambiarTablero(this.dificultad);
            this.GenerarAvatarRandom();
            this.GenerarGemas();
            this.GenerarTrolls();
            this.GenerarPortal();
        }

        /// <summary>
        /// Procedimiento que cambia el tamaño de la matriz mapa con base en la dificultad.
        /// </summary>
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

        /// <summary>
        /// Procedimiento que lleva a cabo la función CambiarTablero.
        /// </summary>
        public void GenerarTablero()
        {
            tablero.CambiarTablero(dificultad);
        }

        /// <summary>
        /// Procedimiento que genera el avatar de forma Aleatoria.
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

        /// <summary>
        /// Procedimiento que genera los trolls de forma aleatoria.
        /// </summary>
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

        /// <summary>
        /// Procedimiento que genera las gemas de forma aleatoria.
        /// </summary>
        public void GenerarGemas()
        {
            int cantidad = (dificultad * 2) + 2;
            gemas = new Gemas[cantidad];
            
            for (int i = 0; i < gemas.Length; i++)
            {
                if (dificultad > 1)
                {
                    if (HayUnLugarDisponible())
                    {
                        Gemas newGema = new Gemas();
                        gemas[i] = newGema;
                        PosicionGema(newGema);
                    }
                }
                else
                {
                    Gemas newGema = new Gemas();
                    gemas[i] = newGema;
                    PosicionGema(newGema);
                }
            }
        }

        /// <summary>
        /// Procedimiento que genera el portal de forma aleatoria.
        /// </summary>
        public void GenerarPortal()
        {
            portal = new Portal();
            PosicionPortal(portal);
        }

        /// <summary>
        /// Procedimiento que asigna una posición aleatoria a los troll.
        /// </summary>
        /// <param name="troll"></param>
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
            //tablero.Controls.Add(troll.troll, posX, posY);
        }

        /// <summary>
        /// Procedimiento que asigna una posición aleatoria a las gemas.
        /// </summary>
        /// <param name="gema"></param>
        private void PosicionGema(Gemas gema)
        {
            int posX, posY;
            int limx = 0, limy = 0;

            switch (dificultad)
            {
                case 32:
                    limx = 4;
                    limy = 5;
                    break;
                case 3:
                    limx = 5;
                    limy = 6;
                    break;
                case 4:
                    limx = 6;
                    limy = 7;
                    break;
                case 5:
                    limx = 10;
                    limy = 10;
                    break;
            }

            if (dificultad == 1)
            {
                do
                {
                    posX = x.Next(0, tablero.RowCount);
                    posY = x.Next(0, tablero.ColumnCount);
                }
                while (mapa[posX, posY] != null || (posX == 2 && posY == 0));

                mapa[posX, posY] = "Gema";
                tablero.Controls.Add(gema.gema, posX, posY);
            }
            else if (dificultad == 2)
            {
                do
                {
                    posX = x.Next(0, 4);
                    posY = x.Next(0, 5);
                }
                while (mapa[posX, posY] != null || posY == 1 || posY == 3 || HayGemaAlrededor(posX, posY));

                mapa[posX, posY] = "Gema";
                tablero.Controls.Add(gema.gema, posX, posY);
            }
            else
            {
                do
                {
                    posX = x.Next(0, limx);
                    posY = x.Next(0, limy);
                }
                while (mapa[posX, posY] != null || HayGemaAlrededor(posX, posY));

                mapa[posX, posY] = "Gema";
                tablero.Controls.Add(gema.gema, posX, posY);
            }

            contgemas++;
        }

        private bool HayUnLugarDisponible()
        {
            for (int i = 0; i < mapa.GetLength(0); i++)
            {
                for (int j = 0; j < mapa.GetLength(1); j++)
                {
                    if (mapa[i,j] == null)
                    {
                        if (HayGemaAlrededor(i, j))
                        {

                        }
                        else
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
        
        private bool HayGemaAlrededor(int posX, int posY)
        {
            int sig1 = posX + 1;
            int sig2 = posX - 1;
            int sig3 = posY + 1;
            int sig4 = posY - 1;

            bool res;
            res = HayUnaGema(posX, sig3);
            if (res)
            {
                return true;
            }
            res = HayUnaGema(posX, sig4);
            if (res)
            {
                return true;
            }
            res = HayUnaGema(sig1, posY);
            if (res)
            {
                return true;
            }
            res = HayUnaGema(sig1, sig3);
            if (res)
            {
                return true;
            }
            res = HayUnaGema(sig1, sig4);
            if (res)
            {
                return true;
            }
            res = HayUnaGema(sig2, posY);
            if (res)
            {
                return true;
            }
            res = HayUnaGema(sig2, sig3);
            if (res)
            {
                return true;
            }
            res = HayUnaGema(sig2, sig4);
            if (res)
            {
                return true;
            }

            return false;
        }
        
        /// <summary>
        /// Procedimiento que asigna una posición aleatoria al portal.
        /// </summary>
        /// <param name="portal"></param>
        private void PosicionPortal(Portal portal)
        {
            int posX, posY;

            if (dificultad == 1)
            {
                posX = 2;
                posY = 0;
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

        /// <summary>
        /// Función que devuelve diferentes valores con base en el objeto que se encuentre en una posición de la matriz mapa.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int SePuedeMover(int x, int y)
        {
            if (x < 0 || x > tablero.RowCount || y < 0 || y > tablero.ColumnCount)
            {
                return -1;
            }
            else if (mapa[x,y] == "Troll")
            {
                MostrarTroll(trolls[0], x, y);
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

        public bool HayUnaGema(int x, int y)
        {
            if (x < 0 || x > tablero.RowCount || y < 0 || y > tablero.ColumnCount ||  x > mapa.GetLength(0) - 1 || y > mapa.GetLength(1) - 1)
            {
                return false;
            }
            if (mapa[x, y] == "Gema")
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Procedimiento que asigna valores a variables o lleva a cabo diferentes procedimientos con base a lo que la función SePuedeMover devuelva como valor.
        /// </summary>
        /// <returns></returns>
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
                mapa[jugador.columnaactual, jugador.filaactual] = null;
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

        /// <summary>
        /// Procedimiento que asigna valores a variables o lleva a cabo diferentes procedimientos con base a lo que la función SePuedeMover devuelva como valor.
        /// </summary>
        /// <returns></returns>
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
                mapa[jugador.columnaactual, jugador.filaactual] = null;
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

        /// <summary>
        /// Procedimiento que asigna valores a variables o lleva a cabo diferentes procedimientos con base a lo que la función SePuedeMover devuelva como valor.
        /// </summary>
        /// <returns></returns>
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
                mapa[jugador.columnaactual, jugador.filaactual] = null;
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

        /// <summary>
        /// Procedimiento que asigna valores a variables o lleva a cabo diferentes procedimientos con base a lo que la función SePuedeMover devuelva como valor.
        /// </summary>
        /// <returns></returns>
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
                mapa[jugador.columnaactual, jugador.filaactual] = null;
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

        /// <summary>
        /// Procedimiento que elimina una gema en el table layout panel y en la matriz mapa con base en posiciones en el eje x y y.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
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

        /// <summary>
        /// Función que encuentra y devuelve un troll con base en posiciones en el eje x y y.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Procedimiento que asigna una nueva posición aleatoria a un troll específico y mueve el avatar a la posicion que ocupaba el troll.
        /// </summary>
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

        /// <summary>
        /// Procedimiento que asigna una nueva posición aleatoria a al portal y mueve el avatar a la posicion que ocupaba el portal.
        /// </summary>
        public void MoverPortal()
        {
            tablero.SuspendLayout();
            tablero.Controls.Remove(portal.portal);

            tablero.Controls.Remove(jugador.avatar);
            tablero.Controls.Add(jugador.avatar, ProxPosicion[0], ProxPosicion[1]);
            jugador.filaactual = ProxPosicion[1];
            jugador.columnaactual = ProxPosicion[0];
            mapa[ProxPosicion[0], ProxPosicion[1]] = "Avatar";
            PosicionPortal(portal);
            tablero.ResumeLayout();
        }

        /// <summary>
        /// Procedimiento que muestra un troll en el table layout panel con base en posiciones x y y.
        /// </summary>
        /// <param name="troll"></param>
        /// <param name="posX"></param>
        /// <param name="posY"></param>
        private void MostrarTroll(Trolls troll, int posX, int posY)
        {
            tablero.Controls.Add(troll.troll, posX, posY);
        }
    }
}
