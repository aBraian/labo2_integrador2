namespace Entidades.Excepciones
{
    public class NombreException : Exception
    {
        public NombreException(string? message) : base(message)
        {
        }

        public NombreException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
