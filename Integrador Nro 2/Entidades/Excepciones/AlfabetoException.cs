namespace Entidades.Excepciones
{
    public class AlfabetoException : Exception
    {
        public AlfabetoException(string? message) : base(message)
        {
        }

        public AlfabetoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
