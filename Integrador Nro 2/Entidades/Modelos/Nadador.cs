using System.Text;

namespace Entidades.Modelos
{
    public class Nadador : Persona
    {
        private ENivel nivel;

        public Nadador(string dni, string nombre, string apellido, string celular, DateTime fechaNacimiento, EHorario horario, ENivel nivel) : base(dni, nombre, apellido, celular, fechaNacimiento, horario)
        {
            this.nivel = nivel;
        }

        public ENivel Nivel
        {
            get
            {
                return this.nivel;
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
                return "Natacion";
            }
        }

        protected override string ObtenerInformacion()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine($"Practica: {this.Deporte}");
            informacion.AppendLine($"Nivel: {this.nivel}");
            return base.ObtenerInformacion() + informacion.ToString();
        }
    }
}
