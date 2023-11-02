using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class FechaNacimientoException : Exception
    {
        public FechaNacimientoException(string? message) : base(message)
        {
        }

        public FechaNacimientoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
