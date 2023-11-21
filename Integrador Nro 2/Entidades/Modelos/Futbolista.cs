using Entidades;
using Entidades.Enumerados;
using Entidades.Excepciones;
using System.Text;

namespace Entidades.Modelos
{
    public class Futbolista : Persona
    {
        private Enum posicion;
        private static int edadMinima;

        /// <summary>
        /// Constructor estatico de la clase Futbolista.
        /// Inicializa la edad minima que se espera de los futbolistas.
        /// </summary>
        static Futbolista()
        {
            edadMinima = 9;
        }

        /// <summary>
        /// Constructor de la clase Futbolista.
        /// Inicializa un futbolista con los datos basicos de una persona.
        /// </summary>
        /// <param name="nombre">Nombre del futbolista.</param>
        /// <param name="apellido">Apellido del futbolista.</param>
        /// <param name="dni">DNI del futbolista.</param>
        /// <param name="celular">Numero de celular del futbolista.</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento del futbolista.</param>
        /// <param name="turno">Turno en el que se inscribe el futbolista.</param>
        public Futbolista(string nombre, string apellido, string dni, string celular, DateTime fechaNacimiento, ETurno turno) 
            : base(nombre, apellido, dni, celular, fechaNacimiento, turno)
        {
        }

        /// <summary>
        /// Constructor de la clase Futbolista.
        /// Inicializa un futbolista con los datos basicos de una persona y su posicion en el campo.
        /// </summary>
        /// <param name="nombre">Nombre del futbolista.</param>
        /// <param name="apellido">Apellido del futbolista.</param>
        /// <param name="dni">DNI del futbolista.</param>
        /// <param name="celular">Numero de celular del futbolista.</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento del futbolista.</param>
        /// <param name="turno">Turno en el que se inscribe el futbolista.</param>
        /// <param name="posicion">Posicion del futbolista en el campo.</param>
        public Futbolista(string nombre, string apellido, string dni, string celular, DateTime fechaNacimiento, ETurno turno, 
            Enum posicion) : this(nombre, apellido, dni, celular, fechaNacimiento, turno)
        {
            this.posicion = posicion;
        }

        /// <summary>
        /// Propiedad de la clase Futbolista.
        /// Obtiene el deporte al que pertenece el futbolista.
        /// </summary>
        public override EDeporte Deporte { get => EDeporte.Futbol; }

        /// <summary>
        /// Propiedad de la clase Futbolista.
        /// Obtiene y establece la posicion del futbolista dentro del campo.
        /// </summary>
        public override Enum Categoria { get => posicion; set => posicion = value; }

        /// <summary>
        /// Propiedad de la clase Futbolista.
        /// Obtiene y establece la edad de un futbolista. Antes de establecerla, se valida la edad.
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
        /// Propiedad de la clase Futbolista.
        /// Obtiene la informacion de un futbolista mediante el metodo ObtenerInformacion.
        /// </summary>
        public override string Informacion { get => ObtenerInformacion(); }

        /// <summary>
        /// Propiedad de la clase Futbolista.
        /// Obtiene una copia del futbolista.
        /// </summary>
        public override Futbolista Copia
        {
            get => new Futbolista(nombre, apellido, dni, celular, fechaNacimiento, turno, posicion);
        }

        /// <summary>
        /// Metodo de la clase Futbolista.
        /// Proporciona la informacion basica de una persona. Agrega la informacion adicional de un futbolista.
        /// </summary>
        /// <returns>Informacion basica de una persona complementada con la informacion de un futbolista</returns>
        protected override string ObtenerInformacion()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine($"Practica: {Deporte}");
            informacion.AppendLine($"Posicion: {posicion}");
            return base.ObtenerInformacion() + informacion.ToString();
        }
    }
}