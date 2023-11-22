using System.Runtime.Serialization;

namespace Entidades.Excepciones
{
    [Serializable]
    public class PrefijoInvalidoException : Exception
    {
        public PrefijoInvalidoException(string? message) : base(message)
        {
        }

        public PrefijoInvalidoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}