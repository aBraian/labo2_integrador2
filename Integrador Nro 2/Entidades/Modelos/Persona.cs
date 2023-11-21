using Entidades;
using Entidades.Enumerados;
using Entidades.Excepciones;
using Entidades.Extensiones;
using Entidades.Interfaces;
using System.Text;

namespace Entidades.Modelos
{
    abstract public class Persona : IDeporte
    {
        protected string nombre;
        protected string apellido;
        protected string dni;
        protected string celular;
        protected DateTime fechaNacimiento;
        protected ETurno turno;
        protected int edad;
        protected static DateTime fechaNacimientoMinima;

        /// <summary>
        /// Constructor estatico de la clase Persona. 
        /// Mantiene la misma fecha de nacimiento minima, para todas las instancias de Persona
        /// y derivadas.
        /// </summary>
        static Persona()
        {
            fechaNacimientoMinima = new DateTime(1950, 1, 1);
        }

        /// <summary>
        /// Constructor protegido de la clase Persona.
        /// Solo pueden acceder las clases derivadas.
        /// Carga los datos basicos de una persona.
        /// Internamente tambien calcula la edad de la persona a traves del metodo ObtenerEdad(), luego se guarda.
        /// </summary>
        /// <param name="nombre">Nombre de la persona.</param>
        /// <param name="apellido">Apellido de la persona.</param>
        /// <param name="dni">DNI de la persona.</param>
        /// <param name="celular">Celular de la persona.</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento de la persona.</param>
        /// <param name="turno">Turno en el que se inscribe la persona.</param>
        protected Persona(string nombre, string apellido, string dni, string celular, DateTime fechaNacimiento,
            ETurno turno)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Celular = celular;
            FechaNacimiento = fechaNacimiento;
            Edad = fechaNacimiento.ObtenerEdad();
            this.turno = turno;
        }

        /// <summary>
        /// Propiedad de la clase Persona.
        /// Permite obtener y establecer el nombre de la persona.
        /// Antes de establecer el nombre, se valida mediante ValidarAlfabeto(), en caso 
        /// de no pasar la validacion se lanza una excepcion del tipo NombreInvalidoException().
        /// </summary>
        public string Nombre
        {
            get => nombre;
            set
            {
                try
                {
                    if (value.EsTextoConEspacios())
                    {
                        nombre = value.Capitalizar();
                    }
                }
                catch (AlfabetoInvalidoException ex)
                {
                    throw new NombreInvalidoException(ex.Message);
                }
            }
        }

        /// <summary>
        /// Propiedad de la clase Persona.
        /// Permite obtener y establecer el apellido de la persona.
        /// Antes de establecer el apellido, se valida mediante ValidarAlfabeto(), en caso 
        /// de no pasar la validacion se lanza una excepcion del tipo ApellidoInvalidoException().
        /// </summary>
        public string Apellido
        {
            get => apellido;
            set
            {
                try
                {
                    if (value.EsTextoConEspacios())
                    {
                        apellido = value.Capitalizar();
                    }
                }
                catch (AlfabetoInvalidoException ex)
                {
                    throw new ApellidoInvalidoException(ex.Message);
                }
            }
        }

        /// <summary>
        /// Propiedad de la clase Persona.
        /// Permite obtener y establecer el DNI de la persona.
        /// Antes de establecer el DNI, se validaSi falla la validacion, se lanza 
        /// una excepcion del tipo DniInvalidoException().
        /// </summary>
        public string Dni
        {
            get => dni;
            set
            {
                try
                {
                    if (value.ValidarEnteroPositivo(8))
                    {
                        dni = value;
                    }
                }
                catch (NumeroInvalidoException ex)
                {
                    throw new DniInvalidoException(ex.Message);
                }
            }
        }

        /// <summary>
        /// Propiedad de la clase Persona.
        /// Permite obtener y establecer el celular de la persona.
        /// Antes de establecer el celular, se valida mediante ValidarCelular(), en caso 
        /// de no pasar la validacion se lanza una excepcion del tipo CelularInvalidoException().
        /// </summary>
        public string Celular
        {
            get => celular;
            set
            {
                try
                {
                    if (ValidarCelular(value))
                    {
                        celular = value;
                    }
                }
                catch (NumeroInvalidoException ex)
                {
                    throw new CelularInvalidoException(ex.Message);
                }
                catch (PrefijoInvalidoException ex)
                {
                    throw new CelularInvalidoException(ex.Message);
                }
            }
        }

        /// <summary>
        /// Propiedad de la clase Persona.
        /// Permite obtener y establecer la fecha de nacimiento de la persona. Antes de establecerla, se valida la 
        /// fecha de nacimiento. Si falla la validacion, se lanza una excepcion del tipo FechaNacimientoInvalidaException.
        /// </summary>
        public DateTime FechaNacimiento
        {
            get => fechaNacimiento;
            set
            {
                if (value.ValidarFechaNacimiento(fechaNacimientoMinima, DateTime.Now))
                {
                    fechaNacimiento = value;
                }
                else
                {
                    throw new FechaNacimientoInvalidaException($"La fecha '{fechaNacimiento:dd/MMM/yyyy}', " +
                    $"esta fuera del rango: minimo {fechaNacimientoMinima:dd/MMM/yyyy} - " +
                    $"maximo {DateTime.Now:dd/MMM/yyyy}");
                }
            }
        }

        /// <summary>
        /// Propiedad de la clase Persona.
        /// Permite obtener y establecer el turno de la persona.
        /// </summary>
        public ETurno Turno { get => turno; set => turno = value; }

        /// <summary>
        /// Propiedad abstracta de la clase Persona.
        /// Se espera que las clases derivadas den  funcionalidad personalizada
        /// de como obtener y establecer la edad.
        /// </summary>
        public abstract int Edad { get; set; }

        /// <summary>
        /// Propiedad abstracta de la clase Persona.
        /// Se espera que las clases derivadas den funcionalidad personalizada
        /// de como obtener la informacion.
        /// </summary>
        public abstract string Informacion { get; }

        /// <summary>
        /// Propiedad abstracta de la clase Persona.
        /// Se espera que las clases derivadas den funcionalidad personalizada
        /// de como obtener el deporte.
        /// </summary>
        public abstract EDeporte Deporte { get; }

        /// <summary>
        /// Propiedad abstracta de la clase Persona.
        /// Se espera que las clases derivadas den funcionalidad personalizada
        /// de como obtener la categoria.
        /// </summary>
        public abstract Enum Categoria { get; set; }

        /// <summary>
        /// Propiedad abstracta de la clase Persona.
        /// Se espera que las clases derivadas den funcionalidad personalizada
        /// de como obtener una copia.
        /// </summary>
        public abstract Persona Copia { get; }

        /// <summary>
        /// Metodo de la clase Persona.
        /// Agrega un punto cada tres caracteres, comenzando desde el final del DNI, para darle formato.
        /// </summary>
        /// <param name="dni">DNI al que se le dara formato.</param>
        /// <returns>DNI con formato.</returns>
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

        /// <summary>
        /// Metodo de la clase Persona.
        /// Valida que el celular ingresado sea un numero entero positivo con una longitud de 10 caracteres.
        /// Ademas, verifica que el prefijo sea 11 o 15. En caso de fallar, se lanza una excepción del tipo
        /// PrefijoInvalidoException.
        /// </summary>
        /// <param name="celular">Celular a validar.</param>
        /// <returns>Booleano que indica si el celular es valido.</returns>
        /// <exception cref="PrefijoInvalidoException">Se lanza cuando el prefijo del celular es invalido.</exception>
        private bool ValidarCelular(string celular)
        {
            if (celular[0] != '1' || (celular[1] != '1' && celular[1] != '5'))
            {
                throw new PrefijoInvalidoException("Prefijo invalido, ingresar 11 o 15.");
            }
            return celular.ValidarEnteroPositivo(10);
        }

        /// <summary>
        /// Metodo virtual de la clase Persona.
        /// Proporciona la informacion basica de una persona. Las clases derivadas pueden agregar informacion adicional.
        /// </summary>
        /// <returns>Informacion de una persona.</returns>
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

        /// <summary>
        /// Sobrecarga del metodo ToString en la clase Persona.
        /// Retorna la informacion proporcionada por el metodo ObtenerInformacion.
        /// </summary>
        /// <returns>Informacion de una persona.</returns>
        public override string ToString()
        {
            return ObtenerInformacion();
        }

        public override bool Equals(object? obj)
        {
            return obj is Persona persona &&
                   dni == persona.dni &&
                   turno == persona.turno;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(dni, turno);
        }

        /// <summary>
        /// Sobrecarga del operador "==" en la clase Persona.
        /// Compara dos instancias de Persona a partir del DNI y turno, e indica si se trata de la misma persona. 
        /// </summary>
        /// <param name="p1">Primera instancia de Persona a comparar.</param>
        /// <param name="p2">Segunda instancia de Persona a comparar.</param>
        /// <returns>Booleano que indica si es la misma persona.</returns>
        public static bool operator ==(Persona p1, Persona p2)
        {
            return p1.dni == p2.dni && p1.turno == p2.turno;
        }

        /// <summary>
        /// Sobrecarga del operador "!=" en la clase Persona.
        /// Compara dos instancias de Persona a partir del DNI y turno, e indica si no se trata de la misma persona. 
        /// </summary>
        /// <param name="p1">Primera instancia de Persona a comparar.</param>
        /// <param name="p2">Segunda instancia de Persona a comparar.</param>
        /// <returns>Booleano que indica si no es la misma persona.</returns>
        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2);
        }
    }
}