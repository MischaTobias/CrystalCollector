using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InicioProyectoCrystalCollector
{
    class Trolls
    {
        PictureBox troll = new PictureBox();

        public Trolls()
        {

        }

        public void GenerarTroll(Tablero TableroDeJuego, int fila, int columna)
        {
            troll.Image = global::InicioProyectoCrystalCollector.Properties.Resources.TrollEnemy;
            troll.Dock = DockStyle.Fill;
            troll.SizeMode = PictureBoxSizeMode.Zoom;
            TableroDeJuego.Controls.Add(troll, columna, fila);
        }
    }
}
