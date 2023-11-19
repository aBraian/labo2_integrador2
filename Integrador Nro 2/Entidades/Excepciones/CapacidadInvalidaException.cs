namespace Entidades.Excepciones
{
    public class CapacidadInvalidaException : Exception
    {
        public CapacidadInvalidaException(string? message) : base(message)
        {
        }

        public CapacidadInvalidaException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
