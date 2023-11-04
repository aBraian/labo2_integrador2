using System.Text;

namespace Entidades.Modelos
{
    public class Futbolista : Persona
    {
        private EPosicion posicion;

        public Futbolista(string nombre, string apellido, string dni, string celular, DateTime fechaNacimiento, ETurno turno, EPosicion posicion) : base(nombre, apellido, dni, celular, fechaNacimiento, turno)
        {
            this.posicion = posicion;
        }

        public EPosicion Posicion
        {
            get
            {
                return this.posicion;
            }
        }

        public override string Informacion
        {
            get
            {
                return ObtenerInformacion();
            }
        }

        public override string Deporte
        {
            get
            {
                return "Futbol";
            }
        }

        protected override string ObtenerInformacion()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine($"Practica: {this.Deporte}");
            informacion.AppendLine($"Posicion: {this.posicion}");
            return base.ObtenerInformacion() + informacion.ToString();
        }
    }
}
