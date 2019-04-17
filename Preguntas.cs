using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicioProyectoCrystalCollector
{
    public class Preguntas
    {
        public string pregunta = "";
        public string[] respuestas = new string[3] {"","",""};
        int respuestaCorrecta = 0;

        // Pregunta pregunta1 = new Pregunta();
        public Preguntas()
        {

        }

        // Pregunta pregunta = new Pregunta("¿Quien escribio Romeo y Julieta?", ["Shakespeare", "Einstein", "Mischa"], 0);

        public Preguntas(string pregunta, string[] respuestas, int respuestaCorrecta)
        {
            this.pregunta = pregunta;
            this.respuestas = respuestas;
            this.respuestaCorrecta = respuestaCorrecta;
        }

        public bool VerificarRespuesta(int respuesta)
        {
            return respuesta == this.respuestaCorrecta;
            // return this.respuestaCorrecta == respuesta; (Devuelve un booleano después de evaluar la expre)
        }
    }
}
