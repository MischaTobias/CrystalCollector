using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicioProyectoCrystalCollector
{
    class Nivel
    {
        Random x = new Random();
        int filaAvatar;
        int columnaAvatar;
        int filaTroll;
        int columnaTroll;


        public Nivel()
        {

        }

        public void GenerarTablero(ref Tablero tablero, int level)
        {
            tablero.CambiarTablero(level);
        }

        public void GenerarAvatarRandom(ref Avatar avatar, ref Tablero tablero, int level)
        {
            if (level == 1)
            {
                filaAvatar = 1;
                columnaAvatar = 1;
            }
            else
            {
                filaAvatar = x.Next(0, tablero.RowCount - 1);
                columnaAvatar = x.Next(0, tablero.ColumnCount - 1);
            }
            avatar.GenerarAvatar(tablero, filaAvatar, columnaAvatar);
        }

        public void GenerarTrollRandom(ref Trolls troll, ref Tablero tablero, int level)
        {
            switch (level)
            {
                case 1:
                    break;
                case 2:
                filaTroll = x.Next(0, tablero.RowCount - 1);
                columnaTroll = x.Next(0, tablero.ColumnCount - 1);
                troll.GenerarTroll(tablero, filaTroll, columnaTroll);
                    break;
            }
        }
    }
}
