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

        public List<Persona> ListaPersonas
        {
            get
            {
                return this.personas;
            }
        }

        private int ObtenerCantidadPersonasTurno(Persona persona)
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

        private bool AgregarFutbolista(Persona persona)
        {
            if (ObtenerCantidadPersonasTurno(persona) >= this.capacidadFutbol)
            {
                throw new PolideportivoException("Capacidad de futbol llena.");
            }
            return true;
        }

        private bool AgregarNadador(Persona persona)
        {
            if (ObtenerCantidadPersonasTurno(persona) >= this.capacidadNatacion)
            {
                throw new PolideportivoException("Capacidad de natacion llena.");
            }
            return true;
        }

        public static Polideportivo operator +(Polideportivo polideportivo, Persona? persona)
        {
            if (persona is null)
            {
                throw new PolideportivoException("Se debe seleccionar un deporte.");
            }
            foreach (Persona item in polideportivo.ListaPersonas)
            {
                if (item == persona)
                {
                    throw new PolideportivoException("La persona ya se encuentra registrada en el turno ingresado.");
                }
            }
            switch (persona.Deporte)
            {
                case "Futbol":
                    if (polideportivo.AgregarFutbolista(persona))
                    {
                        polideportivo.ListaPersonas.Add(persona);
                    }
                    break;
                case "Natacion":
                    if (polideportivo.AgregarNadador(persona))
                    {
                        polideportivo.ListaPersonas.Add(persona);
                    }
                    break;
            }
            return polideportivo;
        }

        public static Polideportivo operator -(Polideportivo polideportivo, Persona persona)
        {
            foreach (Persona p in polideportivo.ListaPersonas)
            {
                if (p == persona)
                {
                    polideportivo.ListaPersonas.Remove(p);
                    break;
                }
            }
            return polideportivo;
        }
    }
}
