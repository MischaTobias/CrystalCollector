using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InicioProyectoCrystalCollector
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Establecimiento de variables.
        /// </summary>
        private Preguntas[] pr = new Preguntas[6];
        private PictureBox troll = new PictureBox();
        private ImpresionTablero impresion = new ImpresionTablero();
        private int nivel = 1;
        private bool Freeze = false;
        private int ContadorPreguntas = 0;
        private int cantidadgemas;
        private int ContadorRespuestasMalas = 0;

        Avatar jugador = new Avatar();
        Nivel lvl = new Nivel();
        Inicio inicio = new Inicio();

        /// <summary>
        /// Constructor del form. Establece valores para los paneles de preguntas y status del juego, además de darle algunos valores al personaje.
        /// 
        /// Además, crea Handlers para los eventos que se ejecutarán cuando las clases envíen el evento.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="genero"></param>
        public Form1(string nombre, bool genero)
        {
            this.KeyPreview = true;
            InitializeComponent();
            this.KeyUp += new KeyEventHandler(this.Form1_KeyDown);
            this.panelPreguntas1.PreguntaRespondida += new PanelPreguntas.PreguntaRespondidaHandler(this.PreguntaRespondida);
            this.panelPreguntas1.CambiarPregunta += new PanelPreguntas.CambiarPreguntaHandler(this.CambiarPregunta);
            this.panelStatusJuego1.ActualizarDatos += new PanelStatusJuego.StatusAvatarHandler(this.ActualizarDatos);
            this.jugador.CambiarNombre(nombre);
            this.jugador.SeleccionarGenero(genero);
            this.jugador.genero = genero;
            DeterminarGenero();
            this.panelStatusJuego1.SetAvatar();
            this.jugador.nombre = nombre;

            this.panelStatusJuego1.EmpezarTimer();
            EstablecerGemasNivel();
            this.panelStatusJuego1.EstablecerGemasNivel(cantidadgemas);
        }

        /// <summary>
        /// Procedimiento que causa que cuando se cargue el form se cree un nuevo objeto de la clase nivel y se lleven a cabo otros procedimientos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            jugador.GeneroAvatar();
            VaciarPanelPreguntas();
            lvl = new Nivel(nivel, TableroDeJuego, jugador);
        }

        /// <summary>
        /// Procedimiento para esconder el Panel de Preguntas.
        /// </summary>
        public void VaciarPanelPreguntas()
        {
            this.panelPreguntas1.Hide();
        }

        /// <summary>
        /// Procedimiento para mostrar el Panel de Preguntas y lleva a cabo GenerarPreguntas().
        /// </summary>
        public void MostrarPanelPreguntas()
        {
            this.panelPreguntas1.Show();
            GenerarPreguntas();
        }

        /// <summary>
        /// Genera los objetos que contiene una matriz de tipo Preguntas, además, indica la respuesta correcta y muestra una pregunta aleatoria en el Panel
        /// de Preguntas.
        /// </summary>
        public void GenerarPreguntas()
        {
            pr[0] = new Preguntas("¿Quién escribió Romeo y Julieta?", new string[3] { "Shakespeare", "Leonardo Da Vinci", "Leonardo DiCaprio" }, 0);
            pr[1] = new Preguntas("¿Cuál de los siguientes es un número primo?", new string[3] { "21", "25", "17" }, 2);
            pr[2] = new Preguntas("¿En qué año se fundó la URL?", new string[3] { "1983", "1961", "1745" }, 1);
            pr[3] = new Preguntas("¿En qué año se estrenó el titanic?", new string[3] { "1997", "2000", "1985" }, 0);
            pr[4] = new Preguntas("¿Cuál es la operación correcta?", new string[3] { "2 + 2 = Pez", "5 x 5 = 120", "Raíz de 144 = 12" }, 2);

            Random numpregunta = new Random();
            int num = numpregunta.Next(0, 5);

            this.panelPreguntas1.AsignarPregunta(pr[num]);
        }

        /// <summary>
        /// Procedimiento para llevar a cabo diferentes procedimientos dependiendo del resultado que entra en un switch.
        /// Solo funciona si el valor "Freeze" tiene asignado un valor verdadero.
        /// 
        /// 
        /// Si, el valor es 0, se mostrará el panel de preguntas y se detendrá el tiempo del Timer del panel de status.
        /// 
        /// Si el valor es 2, se agregará una gema al panel de status y se cambiará el punteo que tiene el avatar.
        /// 
        /// Si el valor es 3, dependiendo de si tiene o no las gemas que son de acuerdo a cada nivel; se moverá el portal y se restarán puntos al avatar.
        /// O, Se cambiará el nivel del juego. Si es el nivel final, se acaba el juego.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Freeze)
            {
                return;
            }
            TableroDeJuego.SuspendLayout();
            switch (e.KeyCode)
            {
                case Keys.Left:
                case Keys.A:
                    if (jugador.columnaactual != 0)
                    {
                        switch (lvl.MoverIzquierda())
                        {
                            case 0:
                                MostrarPanelPreguntas();
                                Freeze = true;
                                this.panelStatusJuego1.PararTimer();
                                break;
                            case 2:
                                this.panelStatusJuego1.AgregarGema();
                                this.jugador.CambiarPunteo(10);
                                break;
                            case 3:
                                if (this.panelStatusJuego1.gemasrecogidas != cantidadgemas)
                                {
                                    lvl.MoverPortal();
                                    jugador.CambiarPunteo(-5);
                                }
                                else if (nivel <= 4)
                                {
                                    this.SuspendLayout();
                                    CambiarNivelDeJuego(true);
                                    this.ResumeLayout();
                                }
                                else
                                {
                                    this.panelStatusJuego1.PararTimer();
                                    Freeze = true;
                                    this.panelStatusJuego1.MostrarFinal();
                                    MessageBox.Show("Ha terminado el juego, felicitaciones", "FIN DEL JUEGO");
                                }
                                break;
                        }
                    }
                    break;
                case Keys.Up:
                case Keys.W:
                    if (jugador.filaactual != 0)
                    {
                        switch (lvl.MoverArriba())
                        {
                            case 0:
                                MostrarPanelPreguntas();
                                Freeze = true;
                                this.panelStatusJuego1.PararTimer();
                                break;
                            case 2:
                                this.panelStatusJuego1.AgregarGema();
                                this.jugador.CambiarPunteo(10);
                                break;
                            case 3:
                                if (this.panelStatusJuego1.gemasrecogidas != cantidadgemas)
                                {
                                    lvl.MoverPortal();
                                    jugador.CambiarPunteo(-5);
                                }
                                else if (nivel <= 4)
                                {
                                    this.SuspendLayout();
                                    CambiarNivelDeJuego(true);
                                    this.ResumeLayout();
                                }
                                else
                                {
                                    this.panelStatusJuego1.PararTimer();
                                    Freeze = true;
                                    this.panelStatusJuego1.MostrarFinal();
                                    MessageBox.Show("Ha terminado el juego, felicitaciones", "FIN DEL JUEGO");
                                }
                                break;
                        }
                    }
                    break;
                case Keys.Right:
                case Keys.D:
                    if (jugador.columnaactual < TableroDeJuego.ColumnCount - 1)
                    {
                        switch (lvl.MoverDerecha())
                        {
                            case 0:
                                MostrarPanelPreguntas();
                                Freeze = true;
                                this.panelStatusJuego1.PararTimer();
                                break;
                            case 2:
                                this.panelStatusJuego1.AgregarGema();
                                this.jugador.CambiarPunteo(10);
                                break;
                            case 3:
                                if (this.panelStatusJuego1.gemasrecogidas != cantidadgemas)
                                {
                                    lvl.MoverPortal();
                                    jugador.CambiarPunteo(-5);
                                }
                                else if (nivel <= 4)
                                {
                                    this.SuspendLayout();
                                    CambiarNivelDeJuego(true);
                                    this.ResumeLayout();
                                }
                                else
                                {
                                    this.panelStatusJuego1.PararTimer();
                                    Freeze = true;
                                    this.panelStatusJuego1.MostrarFinal();
                                    MessageBox.Show("Ha terminado el juego, felicitaciones", "FIN DEL JUEGO");
                                }
                                break;
                        }
                    }
                    break;
                case Keys.Down:
                case Keys.S:
                    if (jugador.filaactual < TableroDeJuego.RowCount - 1)
                    {
                        switch (lvl.MoverAbajo())
                        {
                            case 0:
                                MostrarPanelPreguntas();
                                Freeze = true;
                                this.panelStatusJuego1.PararTimer();
                                break;
                            case 2:
                                this.panelStatusJuego1.AgregarGema();
                                this.jugador.CambiarPunteo(10);
                                break;
                            case 3:
                                if (this.panelStatusJuego1.gemasrecogidas != cantidadgemas)
                                {
                                    lvl.MoverPortal();
                                    jugador.CambiarPunteo(-5);
                                }
                                else if (nivel <= 4)
                                {
                                    this.SuspendLayout();
                                    CambiarNivelDeJuego(true);
                                    this.ResumeLayout();
                                }
                                else
                                {
                                    this.panelStatusJuego1.PararTimer();
                                    Freeze = true;
                                    this.panelStatusJuego1.MostrarFinal();
                                    MessageBox.Show("Ha terminado el juego, felicitaciones", "FIN DEL JUEGO");
                                }
                                break;
                        }
                    }
                    break;
            }
            TableroDeJuego.ResumeLayout();
        }

        /// <summary>
        /// Procedimiendo que se ejecuta cuando el panel de Preguntas envia el evento creado.
        /// 
        /// Dependiendo del resultado de la respuesta, se añaden o se restan puntos y una vida al avatar.
        /// Además, si es verdadero se Cambia de posición el troll, se reinicia el contador de preguntas, se quita el Freeze y se oculta el panel de preguntas.
        /// 
        /// Si responde incorrectamente y el avatar ya no posee vidas, el juego se termina y se muestra el resultado final.
        /// Si responde incorrectamente la tercera pregunta, se reinicia en un nivel inferior.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="resultado"></param>
        private void PreguntaRespondida(object sender, bool resultado)
        {
            if (resultado)
            {
                ContadorPreguntas = 0;
                ContadorRespuestasMalas = 0;
                Freeze = false;
                this.panelStatusJuego1.EmpezarTimer();
                this.panelPreguntas1.CambiarDisponibilidadBtnCambiar(false);
                this.jugador.CambiarPunteo(5);
                this.jugador.CambiarVidas(1);
                lvl.MoverTroll();
                VaciarPanelPreguntas();
            }
            else
            {
                ContadorRespuestasMalas++;
                this.panelPreguntas1.CambiarDisponibilidadBtnCambiar(true);
                jugador.CambiarPunteo(-5);
                jugador.CambiarVidas(-1);

                if (jugador.cantvidas == 0)
                {
                    Freeze = true;
                    MessageBox.Show("Ha perdido todas sus vidas, el juego ha terminado", "FIN DEL JUEGO");
                    this.panelStatusJuego1.MostrarFinal();
                }
                else if (ContadorRespuestasMalas == 3)
                {
                    this.panelStatusJuego1.EmpezarTimer();
                    this.panelPreguntas1.CambiarDisponibilidadBtnCambiar(false);
                    VaciarPanelPreguntas();
                    this.panelStatusJuego1.EstablecerGemasNivel(cantidadgemas);
                    CambiarNivelDeJuego(false);
                    Freeze = false;
                }
            }
        }

        /// <summary>
        /// Procedimiento para cambiar la pregunta y respuestas que se muestran en el Panel de Preguntas.
        /// 
        /// Si ya cambió de pregunta 3 veces, no le permite seguir cambiando de preguntas.
        /// </summary>
        /// <param name="sender"></param>
        private void CambiarPregunta(object sender)
        {
            ContadorPreguntas++;
            Random numpregunta = new Random();
            int num = numpregunta.Next(0, 4);
            if (ContadorPreguntas <= 3)
            {
                this.panelPreguntas1.AsignarPregunta(pr[num]);
                this.panelPreguntas1.CambiarDisponibilidadBtnCambiar(false);
            }
            else
            {
                MessageBox.Show("Ya no puede cambiar su pregunta, responda.", "ADVERTENCIA");
            }
        }

        /// <summary>
        /// Procedimiento que calcula la cantidad de gemas por nivel con base en este.
        /// </summary>
        private void EstablecerGemasNivel()
        {
            cantidadgemas = (nivel * 2) + 2;
        }

        /// <summary>
        /// Procedimiento que cambia el table layout panel en función al nivel; además asigna un punteo al jugador y lleva a cabo otros procedimientos.
        /// </summary>
        /// <param name="respuesta"></param>
        public void CambiarNivelDeJuego(bool respuesta)
        {
            if (respuesta)
            {
                nivel++;
                jugador.CambiarPunteo(20);
            }
            else
            {
                nivel--;
                jugador.CambiarPunteo(-20);
            }

            VaciarPanelPreguntas();
            TableroDeJuego.Controls.Clear();
            lvl = new Nivel(nivel, TableroDeJuego, jugador);
            EstablecerGemasNivel();
            this.panelStatusJuego1.gemasrecogidas = 0;
            this.panelStatusJuego1.EstablecerGemasNivel(cantidadgemas);
            this.panelStatusJuego1.GemasCero();
        }

        /// <summary>
        /// Procedimiento que actúa como handler del evento que envía el panel de Status del Juego; actualiza datos del panel con los datos del avatar y
        /// el tablero de juego.
        /// </summary>
        /// <param name="sender"></param>
        private void ActualizarDatos(object sender)
        {
            this.panelStatusJuego1.nombre = jugador.nombre;
            this.panelStatusJuego1.genero = jugador.genero;
            this.panelStatusJuego1.cantvidas = jugador.cantvidas;
            this.panelStatusJuego1.puntos = jugador.punteo;
            this.panelStatusJuego1.x = jugador.columnaactual;
            this.panelStatusJuego1.y = jugador.filaactual;
            this.panelStatusJuego1.rowcanttablero = TableroDeJuego.RowCount;
            this.panelStatusJuego1.PararTimer();
        }

        /// <summary>
        /// Procedimiento que actualiza el dato genero del panel de Status, con el dato del avatar.
        /// </summary>
        public void DeterminarGenero()
        {
            this.panelStatusJuego1.genero = jugador.genero;
        }

        /// <summary>
        /// Crea un nuevo formulario de Inicio y esconde el form; cuando el formulario de inicio se cierra, este form se cierra.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTerminarPartida_Click(object sender, EventArgs e)
        {
            Inicio NuevoInicio = new Inicio();
            NuevoInicio.FormClosed += new FormClosedEventHandler(TerminarPartida);
            NuevoInicio.Show();
            this.Hide();
        }

        /// <summary>
        /// Procedimiento que cierra este form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TerminarPartida(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Procedimiento que crea un nuevo form para imprimir el tablero y para el timer de panel de status.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImprimirTablero_Click(object sender, EventArgs e)
        {
            this.panelStatusJuego1.PararTimer();
            impresion = new ImpresionTablero(this.lvl.mapa, jugador.filaactual, jugador.columnaactual, nivel, jugador.genero);
            this.impresion.CerrarImpresion += new ImpresionTablero.CerrarImpresionHandler(CerrarImpresion);
            impresion.Show();
        }

        /// <summary>
        /// Cuando el form de ImpresiónTablero se cierra, el procedimiento empieza de nuevo el timer del panel de status.
        /// </summary>
        /// <param name="sender"></param>
        private void CerrarImpresion(object sender)
        {
            this.panelStatusJuego1.EmpezarTimer();
        }
        
    }
}
