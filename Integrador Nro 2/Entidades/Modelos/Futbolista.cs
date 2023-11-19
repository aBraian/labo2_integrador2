using Entidades.Enumerados;
using Entidades.Excepciones;
using System.Text;

namespace Entidades.Modelos
{
    public class Futbolista : Persona
    {
        private EPosicion posicion;
        private static int edadMinima;

        static Futbolista()
        {
            edadMinima = 9;
        }

        public Futbolista(string nombre, string apellido, string dni, string celular, DateTime fechaNacimiento, ETurno turno) : base(nombre, apellido, dni, celular, fechaNacimiento, turno)
        {
        }

        public Futbolista(string nombre, string apellido, string dni, string celular, DateTime fechaNacimiento, ETurno turno, EPosicion posicion) : this(nombre, apellido, dni, celular, fechaNacimiento, turno)
        {
            this.posicion = posicion;
        }

        public EPosicion Posicion
        {
            get
            {
                return this.posicion;
            }
            set
            {
                posicion = value;
            }
        }

        public override int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                if (ValidarEdad(value))
                {
                    this.edad = value;
                }
            }
        }

        public override string Informacion
        {
            get
            {
                return ObtenerInformacion();
            }
        }

        public override EDeporte Deporte
        {
            get
            {
                return EDeporte.Futbol;
            }
        }

        public override Futbolista Copia
        {
            get
            {
                return new Futbolista(nombre, apellido, dni, celular, fechaNacimiento, turno, posicion);
            }
        }

        protected override bool ValidarEdad(int edad)
        {
            if (edad < edadMinima)
            {
                throw new EdadInvalidaException($"No cumple con edad minima ({edadMinima} años) para realizar " +
                    $"{Deporte}.");
            }
            return true;
        }

        protected override string ObtenerInformacion()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine($"Practica: {Deporte}");
            informacion.AppendLine($"Posicion: {posicion}");
            return base.ObtenerInformacion() + informacion.ToString();
        }
    }
}