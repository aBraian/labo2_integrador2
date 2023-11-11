using Entidades.Excepciones;
using System.Numerics;
using System.Text;

namespace Entidades.Modelos
{
    abstract public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected string dni;
        protected string celular;
        protected DateTime fechaNacimiento;
        protected ETurno turno;

        protected Persona(string nombre, string apellido, string dni, string celular , DateTime fechaNacimiento, ETurno turno)
        {
            Nombre = nombre;
            Apellido = apellido; 
            Dni = dni;
            Celular = celular;
            FechaNacimiento = fechaNacimiento;
            this.turno = turno;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                try
                {
                    if (ValidarAlfabeto(value))
                    {
                        this.nombre = value;
                    }
                }
                catch (Exception e)
                {
                    throw new NombreException(e.Message);
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
                try
                {
                    if (ValidarAlfabeto(value))
                    {
                        this.apellido = value;
                    }
                }
                catch (Exception ex)
                {
                    throw new ApellidoException(ex.Message);
                }
            }
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
                    this.dni = value;
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
            set
            {
                if (ValidarFechaNacimiento(value))
                {
                    this.fechaNacimiento = value;
                }
            }
        }

        public ETurno Turno
        {
            get
            {
                return this.turno;
            }
            set
            {
                turno = value;
            }
        }

        public int Edad
        {
            get
            {
                return ObtenerEdad();
            }
        }

        public abstract string Informacion
        {
            get;
        }

        public abstract EDeporte Deporte
        {
            get;
        }

        public abstract Persona Copia
        {
            get;
        }

        private bool ValidarAlfabeto(string cadena)
        {
            List<char> listaError= new List<char>();
            bool flagError = false;
            if (string.IsNullOrEmpty(cadena))
            {
                throw new Exception("El campo esta vacio o es nulo.");
            }
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
                throw new Exception($"Se ingresaron caracteres no validos: {string.Join(',', listaError)}.");
            }
            return true;
        }

        private bool ValidarDni(string cadena)
        {
            if (string.IsNullOrEmpty(cadena))
            {
                throw new DniException("El campo esta vacio o es nulo.");
            }
            else if (cadena.Length != 8)
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
            for (int i = cadena.Length - 1; i >= 0; i--)
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

        private bool ValidarCelular(string cadena)
        {
            if (string.IsNullOrEmpty(cadena))
            {
                throw new CelularException("El campo esta vacio o es nulo.");
            }
            else if (cadena.Length != 10)
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

        private bool ValidarFechaNacimiento(DateTime fechaNacimiento)
        {
            DateTime minimo = new DateTime(1950, 1, 1);
            if (fechaNacimiento > DateTime.Now || fechaNacimiento < minimo)
            {
                throw new FechaNacimientoException("Fecha de nacimiento fuera de rango.");
            }
            return true;
        }

        private int ObtenerEdad()
        {
            DateTime fechaActual = DateTime.Now;
            int edad = fechaActual.Year - fechaNacimiento.Year;
            if (fechaNacimiento.Month <= fechaActual.Month && fechaNacimiento.Day < fechaActual.Day)
            {
                edad--;
            }
            return edad;
        }

        public abstract Persona CambiarDeporte(EDeporte deporte);

        protected virtual string ObtenerInformacion()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine($"Nombre: {nombre}");
            informacion.AppendLine($"Apellido: {apellido}");
            informacion.AppendLine($"DNI: {DarFormatoDni(dni)}");
            informacion.AppendLine($"Celular: {celular}");
            informacion.AppendLine($"Fecha de nacimiento: {fechaNacimiento.ToString("dd/MMMM/yyyy")}");
            informacion.AppendLine($"Edad: {Edad}");
            informacion.AppendLine($"Turno: {turno}");
            return informacion.ToString();
        }

        public override string ToString()
        {
            return ObtenerInformacion();
        }

        public static bool operator ==(Persona p1, Persona p2)
        {
            return p1.dni == p2.dni && p1.turno == p2.turno;
        }

        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2);
        }
    }
}