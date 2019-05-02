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
        /// <summary>
        /// Declaración de variables.
        /// </summary>
        public PictureBox troll = new PictureBox();
        public int[] Coordenadas = new int[2];

        /// <summary>
        /// Constructor Trolls, lleva a cabo el procedimiento GenerarTroll()
        /// </summary>
        public Trolls()
        {
            GenerarTroll();
        }

        /// <summary>
        /// Procedimiento que asigna una imagen a una picturebox y asigna la manera de llenado que la imagen tendrá en la picturebox.
        /// </summary>
        public void GenerarTroll()
        {
            troll.Image = global::InicioProyectoCrystalCollector.Properties.Resources.TrollEnemy;
            troll.Dock = DockStyle.Fill;
            troll.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
