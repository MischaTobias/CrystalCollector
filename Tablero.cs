﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InicioProyectoCrystalCollector
{
    public partial class Tablero : TableLayoutPanel
    {
        /// <summary>
        /// Constructor Tablero
        /// </summary>
        public Tablero()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint |
              ControlStyles.OptimizedDoubleBuffer |
              ControlStyles.UserPaint, true);
        }

        public Tablero(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint |
              ControlStyles.OptimizedDoubleBuffer |
              ControlStyles.UserPaint, true);
        }

        /// <summary>
        /// Dependiendo del nivel de dificultad, lleva a cabo procedimientos con distintos parámetros.
        /// </summary>
        /// <param name="dificultad"></param> La dificultad es un int que entra como un valor de evaluación en un switch.
        public void CambiarTablero(int dificultad)
        {
            switch (dificultad)
            {
                case 1:
                    CambiarColumnas(3);
                    CambiarFilas(3);
                    break;
                case 2:
                    CambiarColumnas(4);
                    CambiarFilas(5);
                    break;
                case 3:
                    CambiarColumnas(5);
                    CambiarFilas(6);
                    break;
                case 4:
                    CambiarColumnas(6);
                    CambiarFilas(7);
                    break;
                case 5:
                    CambiarColumnas(10);
                    CambiarFilas(10);
                    break;
            }
        }

        /// <summary>
        /// Procedimiento que cambia el table layout panel con base a la cantidad de filas que envían como parámetro.
        /// </summary>
        /// <param name="filas"></param>
        public void CambiarFilas(int filas)
        {
            this.SuspendLayout();
            this.RowCount = filas;
            float height = 100 / filas;

            for (int i = 0; i < filas; i++)
            {
                if (this.RowStyles.Count <= i)
                {
                    this.RowStyles.Add(new RowStyle(SizeType.Percent));
                }
                this.RowStyles[i].Height = height;
            }
            this.ResumeLayout();
        }

        /// <summary>
        /// Procedimiento que cambia el table layout panel con base a la cantidad de columnas que envían como parámetro.
        /// </summary>
        /// <param name="columnas"></param>
        public void CambiarColumnas(int columnas)
        {
            this.SuspendLayout();
            this.ColumnCount = columnas;
            float width = 100 / columnas;

            for (int i = 0; i < columnas; i++)
            {
                if (this.ColumnStyles.Count <= i)
                {
                    this.ColumnStyles.Add(new ColumnStyle(SizeType.Percent));
                }
                this.ColumnStyles[i].Width = width;
            }

            this.ResumeLayout();
        }
    }
}
