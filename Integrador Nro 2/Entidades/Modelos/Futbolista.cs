using System.Runtime.CompilerServices;
using System.Text;

namespace Entidades.Modelos
{
    public class Futbolista : Persona
    {
        private EPosicion posicion;

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

        public override Persona CambiarDeporte(EDeporte deporte)
        {
            if (deporte == EDeporte.Natacion)
            {
                return new Nadador(nombre, apellido, dni, celular, fechaNacimiento, turno);
            }
            return this;
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
