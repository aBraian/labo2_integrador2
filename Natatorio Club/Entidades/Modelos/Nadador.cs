using Entidades.Enumerados;
using Entidades.Excepciones;
using Entidades.Extensiones;
using Entidades.Interfaces;
using System.Text;

namespace Entidades.Modelos
{
    sealed public class Nadador : IDeporte
    {
        private string nombre;
        private string apellido;
        private string dni;
        private string telefono;
        private DateTime fechaNacimiento;
        private ETurno turno;
        private ENivel nivel;
        private int edad;
        private static int edadMinima;
        private static DateTime minimoFechaNacimiento;

        /// <summary>
        /// Inicializa la clase Nadador con la edad mínima requerida y la fecha de nacimiento mínima permitida.
        /// </summary>
        static Nadador()
        {
            edadMinima = 4;
            minimoFechaNacimiento = new DateTime(1950, 1, 1);
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Nadador con los datos proporcionados.
        /// </summary>
        /// <param name="nombre">Nombre del nadador.</param>
        /// <param name="apellido">Apellido del nadador.</param>
        /// <param name="dni">DNI del nadador.</param>
        /// <param name="telefono">Número de teléfono del nadador.</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento del nadador.</param>
        /// <param name="turno">Turno en el que se inscribe el nadador.</param>
        /// <param name="nivel">Nivel de experiencia del nadador.</param>
        public Nadador(string nombre, string apellido, string dni, string telefono, DateTime fechaNacimiento, 
            ETurno turno, ENivel nivel)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Telefono = telefono;
            FechaNacimiento = fechaNacimiento;
            Edad = fechaNacimiento.ObtenerEdad();
            this.turno = turno;
            this.nivel = nivel;
        }

        /// <summary>
        /// Obtiene o establece el nombre de la persona.
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
        /// Obtiene o establece el apellido de la persona.
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
        /// Obtiene o establece el número de DNI de la persona.
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
        /// Obtiene o establece el número de teléfono de la persona.
        /// </summary>
        public string Telefono
        {
            get => telefono;
            set
            {
                try
                {
                    if (ValidarTelefono(value))
                    {
                        telefono = value;
                    }
                }
                catch (PrefijoInvalidoException ex)
                {
                    throw new TelefonoInvalidoException(ex.Message);
                }
                catch (NumeroInvalidoException ex)
                {
                    throw new TelefonoInvalidoException(ex.Message);
                }
            }
        }

        /// <summary>
        /// Obtiene o establece la fecha de nacimiento de la persona.
        /// </summary>
        public DateTime FechaNacimiento
        {
            get => fechaNacimiento;
            set
            {
                if (value.ValidarFechaNacimiento(minimoFechaNacimiento, DateTime.Now))
                {
                    fechaNacimiento = value;
                }
                else
                {
                    throw new FechaNacimientoInvalidaException($"La fecha '{fechaNacimiento:dd/MMM/yyyy}', " +
                    $"esta fuera de rango: minimo {minimoFechaNacimiento:dd/MMM/yyyy} - " +
                    $"maximo {DateTime.Now:dd/MMM/yyyy}");
                }
            }
        }

        /// <summary>
        /// Obtiene o establece el turno en el que se inscribe la persona.
        /// </summary>
        public ETurno Turno { get => turno; set => turno = value; }

        /// <summary>
        /// Obtiene la representación en cadena del turno en el que se inscribe la persona.
        /// Esta propiedad se utiliza principalmente para la serialización a JSON,
        /// proporcionando el nombre del turno.
        /// </summary>
        public string Turno_Nombre
        {
            get => turno.ToString();
        }

        /// <summary>
        /// Obtiene o establece el nivel de experiencia de la persona.
        /// </summary>
        public ENivel Nivel { get => nivel; set => nivel = value; }

        /// <summary>
        /// Obtiene la representación en cadena del nivel en el deporte de la persona.
        /// Esta propiedad se utiliza principalmente para la serialización a JSON,
        /// proporcionando el nombre del nivel.
        /// </summary>
        public string Nivel_Nombre
        {
            get => nivel.ToString();
        }

        /// <summary>
        /// Obtiene o establece la edad del nadador. 
        /// Se ignora en la serialización JSON.
        /// </summary>
        [System.Text.Json.Serialization.JsonIgnore]
        public int Edad
        {
            get => edad;
            set
            {
                if (value >= edadMinima)
                {
                    edad = value;
                }
                else
                {
                    throw new EdadInvalidaException($"No cumple con la edad minima ({edadMinima} años) que se requiere " +
                    $"para realizar {Deporte}.");
                }
            }
        }

        /// <summary>
        /// Obtiene el deporte al que pertenece el nadador.
        /// Se ignora en la serialización JSON.
        /// </summary>
        [System.Text.Json.Serialization.JsonIgnore]
        public EDeporte Deporte { get => EDeporte.Natacion; }

        /// <summary>
        /// Obtiene la información del nadador. 
        /// Se ignora en la serialización JSON.
        /// </summary>
        [System.Text.Json.Serialization.JsonIgnore]
        public string Informacion { get => ObtenerInformacion(); }

        /// <summary>
        /// Obtiene una copia del nadador.
        /// Se ignora en la serialización JSON.
        /// </summary>
        [System.Text.Json.Serialization.JsonIgnore]
        public Nadador Copia
        {
            get => new Nadador(nombre, apellido, dni, telefono, fechaNacimiento, turno, nivel);
        }

        /// <summary>
        /// Formatea el DNI con puntos cada tres dígitos.
        /// </summary>
        /// <param name="dni">Número de DNI a formatear.</param>
        /// <returns>Número de DNI formateado.</returns>
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
        /// Valida el formato del número de teléfono y verifica el prefijo.
        /// </summary>
        /// <param name="telefono">Número de teléfono a validar.</param>
        /// <returns>True si el formato y prefijo son válidos; de lo contrario, false.</returns>
        /// <exception cref="PrefijoInvalidoException">Lanzada si el prefijo es inválido.</exception>
        private bool ValidarTelefono(string telefono)
        {
            if (telefono[0] != '1' || (telefono[1] != '1' && telefono[1] != '5'))
            {
                throw new PrefijoInvalidoException("Prefijo invalido, ingresar 11 o 15.");
            }
            if (telefono.ValidarEnteroPositivo(10))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Obtiene la información completa del nadador incluyendo nombre, apellido, DNI, teléfono, 
        /// fecha de nacimiento, edad, turno, deporte y nivel.
        /// </summary>
        /// <returns>Información completa del nadador.</returns>
        private string ObtenerInformacion()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine($"Nombre: {nombre} |");
            informacion.AppendLine($"Apellido: {apellido} |");
            informacion.AppendLine($"DNI: {DarFormatoDni(dni)} |");
            informacion.AppendLine($"Telefono: {telefono} |");
            informacion.AppendLine($"Fecha de nacimiento: {fechaNacimiento:dd/MMMM/yyyy} |");
            informacion.AppendLine($"Edad: {edad} |");
            informacion.AppendLine($"Turno: {turno} |");
            informacion.AppendLine($"Practica: {Deporte} |");
            informacion.AppendLine($"Nivel: {nivel} ");
            return informacion.ToString();
        }

        public override string ToString()
        {
            return ObtenerInformacion();
        }

        public override bool Equals(object? obj)
        {
            return obj is Nadador nadador &&
                   dni == nadador.dni &&
                   turno == nadador.turno;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(dni, turno);
        }

        /// <summary>
        /// Compara dos nadadores para determinar si son iguales, basándose en el DNI y el turno.
        /// </summary>
        /// <param name="x">Primer nadador a comparar.</param>
        /// <param name="y">Segundo nadador a comparar.</param>
        /// <returns>True si los nadadores son iguales; de lo contrario, false.</returns>
        public static bool operator ==(Nadador x, Nadador y)
        {
            return x.dni == y.dni && x.turno == y.turno;
        }

        /// <summary>
        /// Compara dos nadadores para determinar si son diferentes, basándose en el DNI y el turno.
        /// </summary>
        /// <param name="x">Primer nadador a comparar.</param>
        /// <param name="y">Segundo nadador a comparar.</param>
        /// <returns>True si los nadadores son diferentes; de lo contrario, false.</returns>
        public static bool operator !=(Nadador x, Nadador y)
        {
            return !(x == y);
        }
    }
}
