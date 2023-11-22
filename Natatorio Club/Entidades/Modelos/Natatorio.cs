using Entidades.Excepciones;

namespace Entidades.Modelos
{
    public class Natatorio
    {
        private List<Nadador> listaNadadores;
        private int capacidad;

        private Natatorio()
        {
            if (listaNadadores is null) 
            {
                listaNadadores = new List<Nadador>();
            }
        }

        public Natatorio(int capacidad) : this()
        {
            this.capacidad = capacidad;
        }

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

        public void Reemplazar(Nadador nadador, Nadador reemplazo)
        {
            int indice = this[nadador];
            listaNadadores[indice] = reemplazo;
        }

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

        public bool ValidarCapacidad(Nadador nadador)
        {
            if (ContarNadadores(nadador) < capacidad)
            {
                return true;
            }
            throw new NatatorioException($"Capacidad de {nadador.Deporte}, en el '{nadador.Turno}' llena.");
        }

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

        public static Natatorio operator -(Natatorio natatorio, Nadador nadador)
        {
            int indice = natatorio[nadador];
            natatorio.ListaNadadores.RemoveAt(indice);
            return natatorio;
        }

        public static bool operator ==(Natatorio natatorio, Nadador nadador)
        {
            return natatorio.ListaNadadores.Contains(nadador);
        }

        public static bool operator !=(Natatorio natatorio, Nadador nadador)
        {
            return !(natatorio == nadador);
        }
    }
}
