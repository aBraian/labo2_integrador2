using Entidades.Excepciones; 

namespace Testeo.MetodosTests
{
    public static class Util
    {
        public static bool ValidarEnteroPositivo(this string numero)
        {
            if (string.IsNullOrEmpty(numero))
            {
                throw new NumeroInvalidoException("Campo vacio o nulo.");
            }
            if (int.TryParse(numero, out int esNumerico))
            {
                if (esNumerico > 0)
                {
                    return true;
                }
                throw new NumeroInvalidoException($"Ingreso un numero negativo: {numero}.");
            }
            throw new NumeroInvalidoException("Ingreso caracteres no numericos.");
        }

        public static bool ValidarEnteroPositivo(this string numero, int longitud)
        {
            numero.ValidarEnteroPositivo();
            if (longitud <= 0)
            {
                throw new NumeroInvalidoException($"Ingreso una longitud invalida: {longitud}.");
            }
            if (numero.Length != longitud)
            {
                throw new NumeroInvalidoException($"No ingreso cantidad de caracteres esperado ({longitud}).");
            }
            return true;
        }
    }
}
