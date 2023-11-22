namespace Entidades.Excepciones
{
    public class NatatorioException : Exception
    {
        public NatatorioException(string? message) : base(message)
        {
        }

        public NatatorioException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
