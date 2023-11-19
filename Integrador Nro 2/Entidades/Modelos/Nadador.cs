using Entidades.Enumerados;
using Entidades.Excepciones;
using System.Text;

namespace Entidades.Modelos
{
    public class Nadador : Persona
    {
        private ENivel nivel;
        private static int edadMinima;

        static Nadador()
        {
            edadMinima = 4;
        }

        public Nadador(string nombre, string apellido, string dni, string celular, DateTime fechaNacimiento, ETurno turno)
            : base(nombre, apellido, dni, celular, fechaNacimiento, turno)
        {
        }

        public Nadador(string nombre, string apellido, string dni, string celular, DateTime fechaNacimiento, ETurno turno,
            ENivel nivel) : this(nombre, apellido, dni, celular, fechaNacimiento, turno)
        {
            this.nivel = nivel;
        }

        public ENivel Nivel
        {
            get
            {
                return this.nivel;
            }
            set
            {
                nivel = value;
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
                return EDeporte.Natacion;
            }
        }

        public override Nadador Copia
        {
            get
            {
                return new Nadador(nombre, apellido, dni, celular, fechaNacimiento, turno, nivel);
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
            informacion.AppendLine($"Nivel: {nivel}");
            return base.ObtenerInformacion() + informacion.ToString();
        }
    }
}