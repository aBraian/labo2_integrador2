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

        static Nadador()
        {
            edadMinima = 4;
            minimoFechaNacimiento = new DateTime(1950, 1, 1);
        }

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
                catch (NumeroInvalidoException ex)
                {
                    throw new TelefonoInvalidoException(ex.Message);
                }
                catch (PrefijoInvalidoException ex)
                {
                    throw new TelefonoInvalidoException(ex.Message);
                }
            }
        }

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

        public ETurno Turno { get => turno; set => turno = value; }

        public ENivel Nivel { get => nivel; set => nivel = value; }

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

        [System.Text.Json.Serialization.JsonIgnore]
        public EDeporte Deporte { get => EDeporte.Natacion; }

        [System.Text.Json.Serialization.JsonIgnore]
        public string Informacion { get => ObtenerInformacion(); }

        [System.Text.Json.Serialization.JsonIgnore]
        public Nadador Copia
        {
            get => new Nadador(nombre, apellido, dni, telefono, fechaNacimiento, turno, nivel);
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

        private bool ValidarTelefono(string telefono)
        {
            if (telefono[0] != '1' || (telefono[1] != '1' && telefono[1] != '5'))
            {
                throw new PrefijoInvalidoException("Prefijo invalido, ingresar 11 o 15.");
            }
            return telefono.ValidarEnteroPositivo(10);
        }

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

        public static bool operator ==(Nadador x, Nadador y)
        {
            return x.dni == y.dni && x.turno == y.turno;
        }

        public static bool operator !=(Nadador x, Nadador y)
        {
            return !(x == y);
        }
    }
}
