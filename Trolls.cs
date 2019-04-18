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
        public PictureBox troll = new PictureBox();

        public Trolls()
        {
            GenerarTroll();
        }

        public void GenerarTroll()
        {
            troll.Image = global::InicioProyectoCrystalCollector.Properties.Resources.TrollEnemy;
            troll.Dock = DockStyle.Fill;
            troll.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
