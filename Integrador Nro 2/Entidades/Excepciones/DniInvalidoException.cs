namespace Entidades.Excepciones
{
    public class DniInvalidoException : Exception
    {
        public DniInvalidoException(string? message) : base(message)
        {
        }

        public DniInvalidoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
