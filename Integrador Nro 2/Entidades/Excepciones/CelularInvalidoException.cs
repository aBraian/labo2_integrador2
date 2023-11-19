namespace Entidades.Excepciones
{
    public class CelularInvalidoException : Exception
    {
        public CelularInvalidoException(string? message) : base(message)
        {
        }

        public CelularInvalidoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
