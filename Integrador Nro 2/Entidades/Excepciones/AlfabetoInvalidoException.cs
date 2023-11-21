namespace Entidades.Excepciones
{
    public class AlfabetoInvalidoException : Exception
    {
        public AlfabetoInvalidoException(string? message) : base(message)
        {
        }

        public AlfabetoInvalidoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
