using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InicioProyectoCrystalCollector
{
    class Gemas
    {
        public PictureBox gema = new PictureBox();

        public Gemas()
        {
            GenerarGema();
        }

        public void GenerarGema()
        {
            gema.Image = global::InicioProyectoCrystalCollector.Properties.Resources.CircleTime;
            gema.Dock = DockStyle.Fill;
            gema.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
