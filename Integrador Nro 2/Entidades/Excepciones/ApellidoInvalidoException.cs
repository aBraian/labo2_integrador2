namespace Entidades.Excepciones
{
    public class ApellidoInvalidoException : Exception
    {
        public ApellidoInvalidoException(string? message) : base(message)
        {
        }

        public ApellidoInvalidoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
