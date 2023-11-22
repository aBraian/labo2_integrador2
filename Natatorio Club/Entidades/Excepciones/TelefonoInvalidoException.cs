namespace Entidades.Excepciones
{
    public class TelefonoInvalidoException : Exception
    {
        public TelefonoInvalidoException(string? message) : base(message)
        {
        }

        public TelefonoInvalidoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
