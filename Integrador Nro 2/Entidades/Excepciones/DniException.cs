namespace Entidades.Excepciones
{
    public class DniException : Exception
    {
        public DniException(string? message) : base(message)
        {
        }

        public DniException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
