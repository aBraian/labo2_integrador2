using Entidades.Enumerados;
using Entidades.Excepciones;
using Entidades.Extension;
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
        protected int edad;
        protected static DateTime fechaNacimientoMinima;

        static Persona()
        {
            fechaNacimientoMinima = new DateTime(1950, 1, 1);
        }

        protected Persona(string nombre, string apellido, string dni, string celular, DateTime fechaNacimiento, ETurno turno)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Celular = celular;
            FechaNacimiento = fechaNacimiento;
            Edad = ObtenerEdad(fechaNacimiento);
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
                    throw new NombreInvalidoException(e.Message);
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
                    throw new ApellidoInvalidoException(ex.Message);
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
                try
                {
                    if (ValidarDni(value))
                    {
                        this.dni = value;
                    }
                }
                catch (NumeroInvalidoException ex)
                {
                    throw new DniInvalidoException(ex.Message);
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
                try
                {
                    if (ValidarCelular(value))
                    {
                        this.celular = value;
                    }
                }
                catch (NumeroInvalidoException ex)
                {
                    throw new CelularInvalidoException(ex.Message);
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

        public abstract int Edad
        {
            get;
            set;
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
            List<char> listaError = new List<char>();
            bool flagError = false;
            if (string.IsNullOrEmpty(cadena))
            {
                throw new Exception("Campo vacio o nulo.");
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
                throw new Exception($"Ingreso caracteres no validos: {string.Join(',', listaError)}.");
            }
            return true;
        }

        private bool ValidarDni(string dni)
        {
            return dni.ValidarEnteroPositivo(8);
        }

        private string DarFormatoDni(string dni)
        {
            int contador = 0;
            string dniFormateado = string.Empty;
            for (int i = dni.Length - 1; i >= 0; i--)
            {
                contador++;
                dniFormateado = dni[i] + dniFormateado;
                if (contador % 3 == 0)
                {
                    dniFormateado = '.' + dniFormateado;
                }
            }
            return dniFormateado;
        }

        private bool ValidarCelular(string celular)
        {
            if (celular[0] != '1' || (celular[1] != '1' && celular[1] != '5'))
            {
                throw new CelularInvalidoException("Prefijo invalido, ingresar 11 o 15.");
            }
            return celular.ValidarEnteroPositivo(10);
        }

        protected bool ValidarFechaNacimiento(DateTime fechaNacimiento)
        {
            if (fechaNacimiento > DateTime.Now)
            {
                throw new FechaNacimientoInvalidaException($"Ingreso: {fechaNacimiento.ToString("dd/MMM/yyyy")}. " +
                    $"Supera la fecha actual.");
            }
            if (fechaNacimiento < fechaNacimientoMinima)
            {
                throw new FechaNacimientoInvalidaException($"Ingreso: {fechaNacimiento.ToString("dd/MMM/yyyy")}. " +
                    $"Fecha nacimiento minima: {fechaNacimientoMinima.ToString("dd/MMM/yyyy")}");
            }
            return true;
        }

        public int ObtenerEdad(DateTime fechaNacimiento)
        {
            int edad = DateTime.Now.Year - fechaNacimiento.Year;
            if (fechaNacimiento.Month > DateTime.Now.Month ||
                (fechaNacimiento.Month == DateTime.Now.Month && fechaNacimiento.Day > DateTime.Now.Day))
            {
                edad--;
            }
            return edad;
        }

        protected abstract bool ValidarEdad(int edad);

        protected virtual string ObtenerInformacion()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine($"Nombre: {nombre}");
            informacion.AppendLine($"Apellido: {apellido}");
            informacion.AppendLine($"DNI: {DarFormatoDni(dni)}");
            informacion.AppendLine($"Celular: {celular}");
            informacion.AppendLine($"Fecha de nacimiento: {fechaNacimiento.ToString("dd/MMMM/yyyy")}");
            informacion.AppendLine($"Edad: {edad}");
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