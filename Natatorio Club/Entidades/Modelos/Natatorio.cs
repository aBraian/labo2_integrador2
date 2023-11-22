using Entidades.Excepciones;

namespace Entidades.Modelos
{
    public class Natatorio
    {
        private List<Nadador> listaNadadores;
        private int capacidad;

        /// <summary>
        /// Constructor privado de la clase Natatorio.
        /// Inicializa la lista de nadadores si es nula.
        /// </summary>
        private Natatorio()
        {
            if (listaNadadores is null) 
            {
                listaNadadores = new List<Nadador>();
            }
        }

        /// <summary>
        /// Constructor de la clase Natatorio.
        /// Inicializa un natatorio con una capacidad especificada.
        /// </summary>
        /// <param name="capacidad">Capacidad máxima del natatorio.</param>
        public Natatorio(int capacidad) : this()
        {
            this.capacidad = capacidad;
        }

        /// <summary>
        /// Obtiene el índice de un nadador en la lista.
        /// </summary>
        /// <param name="nadador">Nadador a buscar en la lista.</param>
        /// <returns>Índice del nadador en la lista.</returns>
        /// <exception cref="NatatorioException">Se lanza cuando el nadador no se encuentra en la lista.</exception>
        public int this[Nadador nadador]
        {
            get
            {
                int indice = listaNadadores.IndexOf(nadador);
                if (indice < 0)
                {
                    throw new NatatorioException("Persona no encontrada.");
                }
                return indice;
            }
        }

        /// <summary>
        /// Propiedad de la clase Natatorio.
        /// Obtiene y establece la lista de nadadores.
        /// </summary>
        public List<Nadador> ListaNadadores
        {
            get => listaNadadores;
            set
            {
                if (value is not null)
                {
                    listaNadadores = value;
                }
            }
        }

        /// <summary>
        /// Ordena la lista de nadadores según el apellido, nombre, DNI y turno.
        /// </summary>
        public void Ordenar()
        {
            listaNadadores.Sort((x, y) =>
            {
                int comparacionApellido = x.Apellido.CompareTo(y.Apellido);
                if (comparacionApellido != 0)
                {
                    return comparacionApellido;
                }
                int comparacionNombre = x.Nombre.CompareTo(y.Nombre);
                if (comparacionNombre != 0)
                {
                    return comparacionNombre;
                }
                int comparacionDni = x.Dni.CompareTo(y.Dni);
                if (comparacionDni != 0)
                {
                    return comparacionDni;
                }
                return x.Turno.CompareTo(y.Turno);
            });
        }

        /// <summary>
        /// Reemplaza un nadador existente en el natatorio con otro nadador.
        /// </summary>
        /// <param name="nadador">Nadador a ser reemplazado.</param>
        /// <param name="reemplazo">Nuevo nadador que reemplazará al anterior.</param>
        public void Reemplazar(Nadador nadador, Nadador reemplazo)
        {
            int indice = this[nadador];
            listaNadadores[indice] = reemplazo;
        }

        /// <summary>
        /// Cuenta la cantidad de nadadores en el natatorio que tienen el mismo turno que el nadador especificado.
        /// </summary>
        /// <param name="nadador">Nadador cuyo turno se utilizará para contar.</param>
        /// <returns>Cantidad de nadadores con el mismo turno.</returns>
        private int ContarNadadores(Nadador nadador)
        {
            int cantidad = 0;
            foreach (Nadador item in listaNadadores)
            {
                if (item.Turno == nadador.Turno)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }

        /// <summary>
        /// Valida si hay capacidad disponible en el natatorio para un nuevo nadador en el mismo turno.
        /// </summary>
        /// <param name="nadador">Nadador para el cual se verificará la capacidad.</param>
        /// <returns>True si hay capacidad disponible, de lo contrario, se lanza una excepción NatatorioException.</returns>
        /// <exception cref="NatatorioException">Se lanza cuando la capacidad está llena para el turno del nadador.</exception>
        public bool ValidarCapacidad(Nadador nadador)
        {
            if (ContarNadadores(nadador) < capacidad)
            {
                return true;
            }
            throw new NatatorioException($"Capacidad de {nadador.Deporte}, en el '{nadador.Turno}' llena.");
        }

        /// <summary>
        /// Sobrecarga del operador '+' que permite agregar un nadador al natatorio.
        /// </summary>
        /// <param name="natatorio">Natatorio al que se agregará el nadador.</param>
        /// <param name="nadador">Nadador que se agregará al natatorio.</param>
        /// <returns>El natatorio con el nuevo nadador agregado.</returns>
        /// <exception cref="NatatorioException">Se lanza cuando el nadador ya está inscrito en el 
        /// turno seleccionado o cuando la capacidad está llena.</exception>
        public static Natatorio operator +(Natatorio natatorio, Nadador nadador)
        {
            if (natatorio == nadador)
            {
                throw new NatatorioException($"Ya se encuentra inscripto en el turno {nadador.Turno} seleccionado.");
            }
            if (natatorio.ValidarCapacidad(nadador))
            {
                natatorio.ListaNadadores.Add(nadador);
            }
            return natatorio;
        }

        /// <summary>
        /// Sobrecarga del operador '-' que permite quitar un nadador del natatorio.
        /// </summary>
        /// <param name="natatorio">Natatorio del que se quitará el nadador.</param>
        /// <param name="nadador">Nadador que se quitará del natatorio.</param>
        /// <returns>El natatorio con el nadador eliminado.</returns>
        public static Natatorio operator -(Natatorio natatorio, Nadador nadador)
        {
            int indice = natatorio[nadador];
            natatorio.ListaNadadores.RemoveAt(indice);
            return natatorio;
        }

        /// <summary>
        /// Sobrecarga del operador '==' que verifica si un nadador está inscrito en el natatorio.
        /// </summary>
        /// <param name="natatorio">Natatorio en el que se verificará la inscripción.</param>
        /// <param name="nadador">Nadador cuya inscripción se verificará.</param>
        /// <returns>True si el nadador está inscrito en el natatorio, de lo contrario, false.</returns>
        public static bool operator ==(Natatorio natatorio, Nadador nadador)
        {
            return natatorio.ListaNadadores.Contains(nadador);
        }

        /// <summary>
        /// Sobrecarga del operador '!=' que verifica si un nadador no está inscrito en el natatorio.
        /// </summary>
        /// <param name="natatorio">Natatorio en el que se verificará la inscripción.</param>
        /// <param name="nadador">Nadador cuya inscripción se verificará.</param>
        /// <returns>True si el nadador no está inscrito en el natatorio, de lo contrario, false.</returns>
        public static bool operator !=(Natatorio natatorio, Nadador nadador)
        {
            return !(natatorio == nadador);
        }
    }
}
