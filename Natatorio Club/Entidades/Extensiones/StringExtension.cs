using Entidades.Excepciones;
using System.Text.RegularExpressions;

namespace Entidades.Extensiones
{
    public static class StringExtension
    {
        public static string Capitalizar(this string cadena) 
        {
            List<string> retorno = new List<string>();
            cadena = Regex.Replace(cadena.Trim(), @"\s+", " "); 
            foreach (string palabra in cadena.Split(" ")) 
            {
                retorno.Add(char.ToUpper(palabra[0]) + palabra.ToLower().Remove(0, 1));             
            } 
            return string.Join(" ", retorno); 
        }

        public static bool EsTextoConEspacios(this string cadena)
        {
            List<char> errores = new List<char>();
            bool exito = true;
            if (string.IsNullOrWhiteSpace(cadena)) 
            {
                throw new AlfabetoInvalidoException("Campo nulo, vacio o contiene solo espacios en blanco");
            }
            foreach (char caracter in cadena)
            {
                if (!char.IsLetter(caracter) && !char.IsWhiteSpace(caracter))
                {   
                    errores.Add(caracter);
                    exito = false;
                }
            }
            if (!exito)
            {
                throw new AlfabetoInvalidoException($"Se ingresaron caracteres invalidos: {string.Join(",", errores)}");
            }
            return true;
        }

        public static bool ValidarEnteroPositivo(this string numero)
        {
            if (string.IsNullOrEmpty(numero))
            {
                throw new NumeroInvalidoException("Campo vacio o nulo.");
            }
            if (!int.TryParse(numero, out int aux))
            {
                throw new NumeroInvalidoException("Ingreso caracteres no numericos.");
            }
            if (aux < 0)
            {
                throw new NumeroInvalidoException($"Ingreso un numero negativo: {numero}.");
            }
            return true;
        }

        public static bool ValidarEnteroPositivo(this string numero, int longitud)
        {
            numero.ValidarEnteroPositivo();
            if (longitud < 0)
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
