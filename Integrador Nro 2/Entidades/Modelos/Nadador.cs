using Entidades.Enumerados;
using System.Text;

namespace Entidades.Modelos
{
    public class Nadador : Persona
    {
        private ENivel nivel;

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

        protected override string ObtenerInformacion()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine($"Practica: {Deporte}");
            informacion.AppendLine($"Nivel: {nivel}");
            return base.ObtenerInformacion() + informacion.ToString();
        }
    }
}
