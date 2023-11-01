namespace Entidades.Excepciones
{
    public class PolideportivoException : Exception
    {
        public PolideportivoException(string? message) : base(message)
        {
        }

        public PolideportivoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
