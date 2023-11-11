using Entidades.Excepciones;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Entidades.Modelos
{
    public class Polideportivo
    {
        private List<Persona> personas;
        private int capacidadFutbol;
        private int capacidadNatacion;

        private Polideportivo()
        {
            this.personas = new List<Persona>();
        }

        public Polideportivo(int capacidadFutbol, int capacidadNatacion) : this()
        {
            this.capacidadFutbol = capacidadFutbol;
            this.capacidadNatacion = capacidadNatacion;
        }

        public int this[Persona persona]
        {
            get
            {
                foreach (Persona item in personas)
                {
                    if (persona == item)
                    {
                        return personas.IndexOf(persona);
                    }
                }
                throw new PolideportivoException("No se encontro la persona buscada.");
            }
        }

        public List<Persona> ListaPersonas
        {
            get
            {
                return this.personas;
            }
        }

        public void Ordenar()
        {
            ListaPersonas.Sort((persona1, persona2) =>
            {
                int comparacionApellido = persona1.Apellido.CompareTo(persona2.Apellido);
                if (comparacionApellido != 0)
                {
                    return comparacionApellido;
                }
                int comparacionNombre = persona1.Nombre.CompareTo(persona2.Nombre);
                if (persona1.Nombre.CompareTo(persona2.Nombre) != 0)
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

        private int ObtenerCantidadPersonasPorDeporteYTurno(Persona persona)
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

        private bool ValidarCapacidadFutbolPorTurno(Persona persona)
        {
            if (ObtenerCantidadPersonasPorDeporteYTurno(persona) >= this.capacidadFutbol)
            {
                throw new PolideportivoException("Capacidad de futbol llena.");
            }
            return true;
        }

        private bool ValidarCapacidadNatacionPorTurno(Persona persona)
        {
            if (ObtenerCantidadPersonasPorDeporteYTurno(persona) >= this.capacidadNatacion)
            {
                throw new PolideportivoException("Capacidad de natacion llena.");
            }
            return true;
        }

        public bool ValidarTurno(Persona persona)
        {
            if (persona.Deporte == EDeporte.Futbol && ValidarCapacidadFutbolPorTurno(persona))
            {
                return true;
            }
            else if (ValidarCapacidadNatacionPorTurno(persona))
            {
                return true;
            }
            return false;
        }

        public static Polideportivo operator +(Polideportivo polideportivo, Persona persona)
        {
            if (polideportivo == persona)
            {
                throw new PolideportivoException("La persona ya se encuentra registrada en el turno ingresado.");
            }
            if (polideportivo.ValidarTurno(persona))
            {
                polideportivo.ListaPersonas.Add(persona);
            }
            return polideportivo;
        }

        public static Polideportivo operator -(Polideportivo polideportivo, Persona persona)
        {
            foreach (Persona item in polideportivo.ListaPersonas)
            {
                if (item == persona)
                {
                    polideportivo.ListaPersonas.Remove(item);
                    break;
                }
            }
            return polideportivo;
        }

        public static bool operator ==(Polideportivo polideportivo, Persona persona)
        {
            foreach (Persona item in polideportivo.personas)
            {
                if (item == persona)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Polideportivo polideportivo, Persona persona)
        {
            return !(polideportivo == persona);
        }
    }
}
