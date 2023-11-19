namespace Entidades.Excepciones
{
    public class NombreInvalidoException : Exception
    {
        public NombreInvalidoException(string? message) : base(message)
        {
        }

        public NombreInvalidoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
