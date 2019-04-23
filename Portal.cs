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
        /// <summary>
        /// Declaración de variables.
        /// </summary>
        public PictureBox portal = new PictureBox();
        public int[] Coordenadas = new int[2];

        /// <summary>
        /// Constructor Portal, lleva a cabo el procedimiento GenerarPortal()
        /// </summary>
        public Portal()
        {
            GenerarPortal();
        }

        /// <summary>
        /// Procedimiento que asigna una imagen a un picturebox y asigna la manera de llenado que tiene la imagen en el pixture box.
        /// </summary>
        public void GenerarPortal()
        {
            portal.Image = global::InicioProyectoCrystalCollector.Properties.Resources.Portal;
            portal.Dock = DockStyle.Fill;
            portal.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
