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
        /// <summary>
        /// Generación de una picturebox que contendrá la imagen de la gema.
        /// </summary>
        public PictureBox gema = new PictureBox();

        /// <summary>
        /// Constructor que lleva a cabo el procedimiento GenerarGema()
        /// </summary>
        public Gemas()
        {
            GenerarGema();
        }

        /// <summary>
        /// Asigna una imagen y la forma de llenado de imagen que tendrá en el picturebox.
        /// </summary>
        public void GenerarGema()
        {
            gema.Image = global::InicioProyectoCrystalCollector.Properties.Resources.Joya;
            gema.Dock = DockStyle.Fill;
            gema.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
