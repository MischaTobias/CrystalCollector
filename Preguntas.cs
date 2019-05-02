using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicioProyectoCrystalCollector
{
    public class Preguntas
    {
        /// <summary>
        /// Declaración de variables.
        /// </summary>
        public string pregunta = "";
        public string[] respuestas = new string[3] {"","",""};
        int respuestaCorrecta = 0;

        /// <summary>
        /// Constructor Preguntas
        /// </summary>
        public Preguntas()
        {

        }

        // Pregunta pregunta = new Pregunta("¿Quien escribio Romeo y Julieta?", ["Shakespeare", "Einstein", "Mischa"], 0);
        /// <summary>
        /// Constructor que asigna valores a las variables locales.
        /// </summary>
        /// <param name="pregunta"></param>
        /// <param name="respuestas"></param>
        /// <param name="respuestaCorrecta"></param>
        public Preguntas(string pregunta, string[] respuestas, int respuestaCorrecta)
        {
            this.pregunta = pregunta;
            this.respuestas = respuestas;
            this.respuestaCorrecta = respuestaCorrecta;
        }

        /// <summary>
        /// Función que devuelve un valor booleano con base en una variable respuesta.
        /// </summary>
        /// <param name="respuesta"></param>
        /// <returns></returns>
        public bool VerificarRespuesta(int respuesta)
        {
            return respuesta == this.respuestaCorrecta;
        }
    }
}
