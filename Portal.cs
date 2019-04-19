using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InicioProyectoCrystalCollector
{
    class Portal
    {
        public PictureBox portal = new PictureBox();
        public int[] Coordenadas = new int[2];

        public Portal()
        {
            GenerarPortal();
        }

        public void GenerarPortal()
        {
            portal.Image = global::InicioProyectoCrystalCollector.Properties.Resources.Portal;
            portal.Dock = DockStyle.Fill;
            portal.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
