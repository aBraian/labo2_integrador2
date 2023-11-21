using Entidades;
using Entidades.Enumerados;
using Entidades.Excepciones;
using System.Text;

namespace Entidades.Modelos
{
    public class Nadador : Persona
    {
        private Enum nivel;
        private static int edadMinima;

        /// <summary>
        /// Constructor estatico de la clase Nadador.
        /// Inicializa la edad minima que se espera de los nadadores.
        /// </summary>
        static Nadador()
        {
            edadMinima = 4;
        }

        /// <summary>
        /// Constructor de la clase Nadador.
        /// Inicializa un nadador con los datos basicos de una persona.
        /// </summary>
        /// <param name="nombre">Nombre del nadador.</param>
        /// <param name="apellido">Apellido del nadador.</param>
        /// <param name="dni">DNI del nadador.</param>
        /// <param name="celular">Numero de celular del nadador.</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento del nadador.</param>
        /// <param name="turno">Turno en el que se inscribe el nadador.</param>
        public Nadador(string nombre, string apellido, string dni, string celular, DateTime fechaNacimiento, ETurno turno)
            : base(nombre, apellido, dni, celular, fechaNacimiento, turno)
        {
        }

        /// <summary>
        /// Constructor de la clase Nadador.
        /// Inicializa un nadador con los datos basicos de una persona y su nivel de natacion.
        /// </summary>
        /// <param name="nombre">Nombre del nadador.</param>
        /// <param name="apellido">Apellido del nadador.</param>
        /// <param name="dni">DNI del nadador.</param>
        /// <param name="celular">Numero de celular del nadador.</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento del nadador.</param>
        /// <param name="turno">Turno en el que se inscribe el nadador.</param>
        /// <param name="nivel">Nivel de experiencia del nadador.</param>
        public Nadador(string nombre, string apellido, string dni, string celular, DateTime fechaNacimiento, ETurno turno,
            Enum nivel) : this(nombre, apellido, dni, celular, fechaNacimiento, turno)
        {
            this.nivel = nivel;
        }

        /// <summary>
        /// Propiedad de la clase Nadador.
        /// Obtiene el deporte al que pertenece el nadador.
        /// </summary>
        public override EDeporte Deporte { get => EDeporte.Natacion; }

        /// <summary>
        /// Propiedad de la clase Nadador.
        /// Obtiene y establece el nivel del nadador dentro del campo.
        /// </summary>
        public override Enum Categoria { get => nivel; set => nivel = value; }

        /// <summary>
        /// Propiedad de la clase Nadador.
        /// Obtiene y establece la edad de un nadador. Antes de establecerla, se valida la edad.
        /// Si falla la validacion, se lanza una excepcion del tipo EdadInvalidaException.
        /// </summary>
        public override int Edad
        {
            get => edad;
            set
            {
                if (value >= edadMinima)
                {
                    edad = value;
                }
                else
                {
                    throw new EdadInvalidaException($"No cumple con la edad minima ({edadMinima} años) que se requiere " +
                    $"para realizar {Deporte}.");
                }
            }
        }

        /// <summary>
        /// Propiedad de la clase Nadador.
        /// Obtiene la informacion de un nadador mediante el metodo ObtenerInformacion.
        /// </summary>
        public override string Informacion { get => ObtenerInformacion(); }

        /// <summary>
        /// Propiedad de la clase Nadador.
        /// Obtiene una copia del nadador.
        /// </summary>
        public override Nadador Copia
        {
            get => new Nadador(nombre, apellido, dni, celular, fechaNacimiento, turno, nivel);
        }

        /// <summary>
        /// Metodo de la clase Nadador.
        /// Proporciona la informacion basica de una persona. Agrega la informacion adicional de un nadador.
        /// </summary>
        /// <returns>Informacion basica de una persona complementada con la informacion de un nadador</returns>
        protected override string ObtenerInformacion()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine($"Practica: {Deporte}");
            informacion.AppendLine($"Nivel: {nivel}");
            return base.ObtenerInformacion() + informacion.ToString();
        }
    }
}