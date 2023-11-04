namespace Entidades.Excepciones
{
    public class ApellidoException : Exception
    {
        public ApellidoException(string? message) : base(message)
        {
        }

        public ApellidoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
