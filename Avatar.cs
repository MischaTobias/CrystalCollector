using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InicioProyectoCrystalCollector
{
    class Avatar
    {
        private int genero;
        private string nombre;
        private int cantvidas;
        private int punteo;
        private int cantgemasrecolectadas;
        public int columnaactual;
        public int filaactual;
        private int tiempojugado;
        public PictureBox avatar = new PictureBox();

        public Avatar()
        {

        }

        public void CambiarNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SeleccionarGenero(int genero)
        {
            this.genero = genero;
        }

        public void CambiarPunteo(int puntos)
        {
            this.punteo += puntos;
        }

        public void EstablecerGemasRecolectadas(int gemas)
        {
            this.cantgemasrecolectadas += gemas;
        }

        public void CambiarVidas(int vida)
        {
            this.cantvidas += vida;
        }

        public void ExtraerCoordenadas()
        {

        }

        public int MostrarTiempoJugado(int tiempo)
        {
            this.tiempojugado = tiempo;
            return this.tiempojugado;
        }

        public void GeneroAvatar(int genero)
        {
            if (genero == 0)
            {
                avatar.Image = global::InicioProyectoCrystalCollector.Properties.Resources.MaleWarrior;
            }
            else
            {
                avatar.Image = global::InicioProyectoCrystalCollector.Properties.Resources.FemaleWarrior;
            }
            avatar.Dock = DockStyle.Fill;
            avatar.SizeMode = PictureBoxSizeMode.Zoom;
        }

        public void GenerarAvatar(Tablero TableroDeJuego, int fila, int columna)
        {
            TableroDeJuego.Controls.Add(avatar, columna, fila);
            this.columnaactual = columna;
            this.filaactual = fila;
            
        }
    }
}
