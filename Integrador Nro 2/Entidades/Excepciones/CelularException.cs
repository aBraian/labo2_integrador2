namespace Entidades.Excepciones
{
    public class CelularException : Exception
    {
        public CelularException(string? message) : base(message)
        {
        }

        public CelularException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
