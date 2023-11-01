using System.Text;

namespace Entidades.Modelos
{
    public class Futbolista : Persona
    {
        private EPosicion posicion;

        public Futbolista(string dni, string nombre, string apellido, string celular, DateTime fechaNacimiento, EHorario horario, EPosicion posicion) : base(dni, nombre, apellido, celular, fechaNacimiento, horario)
        {
            this.posicion = posicion;
        }

        public enum EPosicion
        {
            Arquero,
            Defensor,
            Mediocampista,
            Delantero
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
