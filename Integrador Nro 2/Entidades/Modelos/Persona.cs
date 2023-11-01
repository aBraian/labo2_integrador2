using Entidades.Excepciones;
using System.Numerics;
using System.Text;

namespace Entidades.Modelos
{
    abstract public class Persona
    {
        protected string dni;
        protected string nombre;
        protected string apellido;
        protected string celular;
        protected DateTime fechaNacimiento;
        protected EHorario horario;

        protected Persona(string dni, string nombre, string apellido, string celular, DateTime fechaNacimiento, EHorario horario)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellido = apellido; 
            this.Celular = celular;
            this.fechaNacimiento = fechaNacimiento;
            this.horario = horario;
        }

        public string Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                if (ValidarDni(value))
                {
                    this.dni = DarFormatoDni(value);
                }
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if (ValidarAlfabeto(value))
                {
                    this.nombre = value;
                }
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                if (ValidarAlfabeto(value))
                {
                    this.apellido = value;
                }
            }
        }

        public string Celular
        {
            get
            {
                return this.celular;
            }
            set
            {
                if (ValidarCelular(value))
                {
                    this.celular = value;
                }
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return this.fechaNacimiento;
            }
        }

        public EHorario Horario
        {
            get
            {
                return this.horario;
            }
        }

        public abstract string Informacion
        {
            get;
        }

        public abstract string Deporte
        {
            get;
        }

        private bool ValidarDni(string cadena)
        {
            if (cadena.Length != 8)
            {
                throw new DniException("No se ingreso la cantidad de caracteres esperada (8).");
            }
            else if (!int.TryParse(cadena, out _))
            {
                throw new DniException("Se ingresaron caracteres no numericos.");
            }
            return true;
        }

        private string DarFormatoDni(string cadena)
        {
            int contador = 0;
            string dniFormateado = string.Empty;
            for (int i = cadena.Length; i >= 0; i--)
            {
                contador++;
                dniFormateado = cadena[i] + dniFormateado;
                if (contador % 3 == 0)
                {
                    dniFormateado = '.' + dniFormateado;
                }
            }
            return dniFormateado;
        }

        private bool ValidarAlfabeto(string cadena)
        {
            List<char> listaError= new List<char>();
            bool flagError = false;
            foreach (char caracter in cadena)
            {
                if (!char.IsLetter(caracter) && caracter != ' ')
                {
                    flagError = true;
                    listaError.Add(caracter);
                }
            }
            if (flagError)
            {
                throw new AlfabetoException($"Se ingresaron caracteres no validos: {string.Join(',', listaError)}.");
            }
            return true;
        }

        private bool ValidarCelular(string cadena)
        {
            if (cadena.Length != 10)
            {
                throw new CelularException("No se ingreso la cantidad de caracteres esperada (10).");
            }
            else if (!int.TryParse(cadena, out _))
            {
                throw new CelularException("Se ingresaron caracteres no numericos.");
            }
            else if (cadena[0] != '1' || cadena[1] != '5')
            {
                throw new CelularException("No se ingreso el prefijo esperado (15).");
            }
            return true;
        }

        protected virtual string ObtenerInformacion()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine($"Nombre: {this.nombre}");
            informacion.AppendLine($"Apellido: {this.apellido}");
            informacion.AppendLine($"DNI: {this.dni}");
            informacion.AppendLine($"Celular: {this.celular}");
            informacion.AppendLine($"Fecha de nacimiento: {this.fechaNacimiento.ToString("dd/MMMM/yyyy")}");
            informacion.AppendLine($"Horario: {this.horario}");
            return informacion.ToString();
        }

        public static bool operator ==(Persona p1, Persona p2)
        {
            return p1.dni == p2.dni && p1.horario == p2.horario;
        }

        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2);
        }
    }
}