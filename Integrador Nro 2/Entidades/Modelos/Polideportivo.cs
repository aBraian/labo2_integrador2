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

        public int CantidadFutbolistas
        {
            get
            {
                return ObtenerCantidadPersonasPorDeporte("Futbol");
            }
        }

        public int CantidadNadadores
        {
            get
            {
                return ObtenerCantidadPersonasPorDeporte("Natacion");
            }
        }

        private int ObtenerCantidadPersonasPorDeporte(string deporte)
        {
            int cantidad = 0;
            foreach (Persona persona in this.personas)
            {
                if (persona.Deporte == deporte)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }

        private bool AgregarFutbolista()
        {
            if (CantidadFutbolistas >= this.capacidadFutbol)
            {
                throw new PolideportivoException("Capacidad de futbol llena.");
            }
            return true;
        }

        private bool AgregarNadador()
        {
            if (CantidadNadadores >= this.capacidadNatacion)
            {
                throw new PolideportivoException("Capacidad de natacion llena.");
            }
            return true;
        }

        public static Polideportivo operator +(Polideportivo polideportivo, Persona persona)
        {
            foreach (Persona p in polideportivo.ListaPersonas)
            {
                if (p == persona)
                {
                    throw new PolideportivoException("La persona ya se encuentra registrada en el horario ingresado.");
                }
            }
            switch (persona.Deporte)
            {
                case "Futbol":
                    if (polideportivo.AgregarFutbolista())
                    {
                        polideportivo.ListaPersonas.Add(persona);
                    }
                    break;
                case "Natacion":
                    if (polideportivo.AgregarNadador())
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
