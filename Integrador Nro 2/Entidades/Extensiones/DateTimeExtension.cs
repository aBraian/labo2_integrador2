using Entidades.Excepciones;

namespace Entidades.Extensiones
{
    public static class DateTimeExtension
    {
        /// /// <summary>
        /// Metodo de extension de la clase DateTimeExtension.
        /// Calcula la edad de una persona a partir de su fecha de nacimiento.
        /// </summary>
        /// <param name="fechaNacimiento">Fecha de nacimiento de la persona.</param>
        /// <returns>Edad de la persona.</returns>
        public static int ObtenerEdad(this DateTime fechaNacimiento)
        {
            int edad = DateTime.Now.Year - fechaNacimiento.Year;
            if (fechaNacimiento.Month > DateTime.Now.Month ||
                (fechaNacimiento.Month == DateTime.Now.Month && fechaNacimiento.Day > DateTime.Now.Day))
            {
                edad--;
            }
            return edad;
        }

        /// <summary>
        /// Metodo de extension de la clase DateTimeExtension.
        /// Valida que la fecha de nacimiento se encuentre dentro de un rango especifico.
        /// </summary>
        /// <param name="fechaNacimiento">Fecha de nacimiento a validar.</param>
        /// <returns>Booleano que indica si la fecha de nacimiento se encuentra dentro de rango.</returns>
        public static bool ValidarFechaNacimiento(this DateTime fechaNacimiento, DateTime minimo, DateTime maximo)
        {
            return fechaNacimiento >= minimo && fechaNacimiento <= maximo;
        }
    }
}
