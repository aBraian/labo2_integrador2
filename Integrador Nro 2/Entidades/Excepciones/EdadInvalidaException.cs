namespace Entidades.Excepciones
{
    public class EdadInvalidaException : Exception
    {
        public EdadInvalidaException(string? message) : base(message)
        {
        }

        public EdadInvalidaException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}