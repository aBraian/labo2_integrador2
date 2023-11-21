using Entidades.Enumerados;
using Entidades.Excepciones;

namespace Entidades.Modelos
{
    public sealed class Polideportivo
    {
        private List<Persona> personas;
        private int capacidadFutbol;
        private int capacidadNatacion;

        /// <summary>
        /// Constructor privado de la clase Polideportivo. Inicializa la lista de personas.
        /// </summary>
        private Polideportivo()
        {
            this.personas = new List<Persona>();
        }

        /// <summary>
        /// Constructor publico de la clase Polideportivo.  
        /// Inicializa la lista de personas, luego carga el limite de personas que se 
        /// podran inscribir a Futbol y Natacion.
        /// </summary>
        /// <param name="capacidadFutbol">Limite de personas inscriptas a Futbol.</param>
        /// <param name="capacidadNatacion">Limite de personas inscriptas a Natacion.</param>
        public Polideportivo(int capacidadFutbol, int capacidadNatacion) : this()
        {
            this.capacidadFutbol = capacidadFutbol;
            this.capacidadNatacion = capacidadNatacion;
        }

        /// <summary>
        /// Indexador de la clase Polideportivo. 
        /// Devuelve la posicion (indice) de la persona buscada dentro de la lista de personas. 
        /// Si no se encuentra la persona lanza una excepcion.
        /// </summary>
        /// <param name="persona">Persona buscada.</param>
        /// <returns>Posicion de la persona</returns>
        /// <exception cref="PolideportivoException">No se encontro la persona.</exception>
        public int this[Persona persona]
        {
            get
            {
                int indice = personas.IndexOf(persona);
                if (indice < 0)
                {
                    throw new PolideportivoException("No se encontro la persona.");
                }
                return indice;
            }
        }

        /// <summary>
        /// Propiedad de la clase Polideportivo. 
        /// Devuelve la lista de personas inscriptas.
        /// </summary>
        public List<Persona> ListaPersonas
        {
            get
            {
                return this.personas;
            }
        }

        /// <summary>
        /// Metodo de la clase Polideportivo.
        /// Ordena las personas por multiples criterios. 
        /// Primero segun apellido. 
        /// En caso de igualdad de apellido, el criterio pasa a ser su nombre. 
        /// En caso de igualdad de nombre, el criterio pasa a ser su DNI. 
        /// En caso de igualdad de DNI, el criterio pasa a ser el turno.
        /// </summary>
        public void Ordenar()
        {
            personas.Sort((persona1, persona2) =>
            {
                int comparacionApellido = persona1.Apellido.CompareTo(persona2.Apellido);
                if (comparacionApellido != 0)
                {
                    return comparacionApellido;
                }
                int comparacionNombre = persona1.Nombre.CompareTo(persona2.Nombre);
                if (comparacionNombre != 0)
                {
                    return comparacionNombre;
                }
                int comparacionDni = persona1.Dni.CompareTo(persona2.Dni);
                if (comparacionDni != 0)
                {
                    return comparacionDni;
                }
                return persona1.Turno.CompareTo(persona2.Turno);
            });
        }

        /// <summary>
        /// Metodo de la clase Polideportivo.
        /// Reemplaza los datos de una persona por los de otra.
        /// </summary>
        /// <param name="persona">Datos de persona a reemplazar.</param>
        /// <param name="reemplazo">Reemplazo.</param>
        public void Reemplazar(Persona persona, Persona reemplazo)
        {
            int indice = this[persona];
            ListaPersonas[indice] = reemplazo;
        }

        /// <summary>
        /// Metodo de clase Polideportivo.
        /// Obtiene la cantidad de personas segun un deporte y turno determinado.
        /// </summary>
        /// <param name="persona">Persona de la que se obtiene el deporte y turno para contar.</param>
        /// <returns>Cantidad de personas en un deporte y turno determinado.</returns>
        private int ContarPersonas(Persona persona)
        {
            int cantidad = 0;
            foreach (Persona item in this.personas)
            {
                if (item.Deporte == persona.Deporte && item.Turno == persona.Turno)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }

        /// <summary>
        /// Metodo de la clase Polideportivo.
        /// Valida que haya capacidad disponible para el deporte y turno, en el que se 
        /// trata de inscribir la persona.
        /// </summary>
        /// <param name="persona">Persona que se quiere inscribir.</param>
        /// <returns>Booleano que representa que hay capacidad.</returns>
        /// <exception cref="PolideportivoException">Capacidad llena.</exception>
        public bool ValidarCapacidad(Persona persona)
        {
            int cantidad = ContarPersonas(persona);
            if (persona.Deporte == EDeporte.Futbol && cantidad < capacidadFutbol)
            {
                return true;
            }
            else if (cantidad < capacidadNatacion)
            {
                return true;
            }
            throw new PolideportivoException($"Capacidad de {persona.Deporte}, en el '{persona.Turno}' llena.");
        }

        /// <summary>
        /// Sobrecarga del operador '+' en la clase Polideportivo.
        /// Valida que la persona no este inscripta en el deporte y turno seleccionado, tambien que haya 
        /// capacidad disponible.
        /// En caso de pasar ambas validaciones se agrega la persona a lista de personas.
        /// </summary>
        /// <param name="polideportivo">Lugar en el que se inscribe la persona.</param>
        /// <param name="persona">Persona a inscribir.</param>
        /// <returns>Polideportivo con la persoan agregada.</returns>
        /// <exception cref="PolideportivoException">No fue posible agregar la persona.</exception>
        public static Polideportivo operator +(Polideportivo polideportivo, Persona persona)
        {
            if (polideportivo == persona)
            {
                throw new PolideportivoException("Persona inscripta en turno seleccionado.");
            }
            if (polideportivo.ValidarCapacidad(persona))
            {
                polideportivo.ListaPersonas.Add(persona);
            }
            return polideportivo;
        }

        /// <summary>
        /// Sobrecarga del operador '-' en la clase Polideportivo.
        /// Busca una persona y la elimina de la lista de personas.
        /// </summary>
        /// <param name="polideportivo">Lugar del que se elimina la persona.</param>
        /// <param name="persona">Persona a eliminar.</param>
        /// <returns>Polideportivo con la persoan eliminada.</returns>
        public static Polideportivo operator -(Polideportivo polideportivo, Persona persona)
        {
            int indice = polideportivo[persona];
            polideportivo.ListaPersonas.RemoveAt(indice);
            return polideportivo;
        }

        /// <summary>
        /// Sobrecarga del operador '==' en la clase Polideportivo.
        /// Busca si la persona se encuentra en la lista de personas.
        /// </summary>
        /// <param name="polideportivo">Polideportivo que contiene las personas.</param>
        /// <param name="persona">Persona a buscar en la lista.</param>
        /// <returns>Booleano que representa si la persona esta en la lista de personas</returns>
        public static bool operator ==(Polideportivo polideportivo, Persona persona)
        {
            return polideportivo.ListaPersonas.Contains(persona);
        }

        /// <summary>
        /// Sobrecarga del operador '!=' en la clase Polideportivo.
        /// Busca si la persona no se encuentra en la lista de personas.
        /// </summary>
        /// <param name="polideportivo">Polideportivo que contiene las personas.</param>
        /// <param name="persona">Persona a buscar en la lista.</param>
        /// <returns>Booleano que representa si la persona no esta en la lista de personas.</returns>
        public static bool operator !=(Polideportivo polideportivo, Persona persona)
        {
            return !(polideportivo == persona);
        }
    }
}
