using System.Text;

namespace Entidades.Modelos
{
    public class Nadador : Persona
    {
        private ENivel nivel;

        public Nadador(string nombre, string apellido, string dni, string celular, DateTime fechaNacimiento, ETurno turno, ENivel nivel) : base(nombre, apellido, dni, celular, fechaNacimiento, turno)
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
            informacion.AppendLine($"Practica: {Deporte}");
            informacion.AppendLine($"Nivel: {nivel}");
            return base.ObtenerInformacion() + informacion.ToString();
        }
    }
}
