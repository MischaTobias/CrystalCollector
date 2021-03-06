﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InicioProyectoCrystalCollector
{
    class Avatar
    {
        /// <summary>
        /// Se establecen las variables para que el objeto de tipo avatar las pueda almacenar.
        /// </summary>
        public bool genero;
        public string nombre;
        public int cantvidas = 3;
        public int punteo;
        public int columnaactual;
        public int filaactual;
        public PictureBox avatar = new PictureBox();

        /// <summary>
        /// Constructor Avatar
        /// </summary>
        public Avatar()
        {

        }

        /// <summary>
        /// Procedimiento para asignarle el nombre al avatar.
        /// </summary>
        /// <param name="nombre"></param> Recibe el nombre enviado como parámetro.
        public void CambiarNombre(string nombre)
        {
            this.nombre = nombre;
        }

        /// <summary>
        /// Procedimiento para asignar el género al avatar.
        /// </summary>
        /// <param name="genero"></param> Recibe un booleano que establece el género local.
        public void SeleccionarGenero(bool genero)
        {
            this.genero = genero;
        }

        /// <summary>
        /// Procedimiento para cambiar el punteo que tiene el avatar.
        /// </summary>
        /// <param name="puntos"></param> Recibe un int como parametro que se suma a la variable local.
        public void CambiarPunteo(int puntos)
        {
            this.punteo += puntos;
        }

        /// <summary>
        /// Procedimiento que cambia la cantidad de vidas que tiene el avatar.
        /// </summary>
        /// <param name="vida"></param> Recibe un int como parámetro que se suma a la variable local.
        public void CambiarVidas(int vida)
        {
            this.cantvidas += vida;
        }

        /// <summary>
        /// Procedimiento para asignar una imagen al avatar y se ajusta el tamaño que ocupará en una pictureBox.
        /// </summary>
        public void GeneroAvatar()
        {
            if (genero)
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
    }
}
