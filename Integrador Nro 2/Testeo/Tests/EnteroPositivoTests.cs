using Entidades.Excepciones;
using Testeo.MetodosTests;

namespace Testeo.Tests
{
    [TestClass]
    public class EnteroPositivoTests
    {
        [TestMethod]
        [ExpectedException (typeof(NumeroInvalidoException))]
        [DataRow (null)]
        [DataRow ("")]
        public void ValidarEnteroPositivo_CuandoNumeroEsNuloOVacio_LanzoExcepcion(string numero)
        {
            numero.ValidarEnteroPositivo();
        }

        [TestMethod]
        [ExpectedException(typeof(NumeroInvalidoException))]
        [DataRow("123abc")]
        [DataRow("abc")]
        [DataRow("!$")]
        public void ValidarEnteroPositivo_CuandoNumeroEsNoNumerico_LanzoExcepcion(string numero)
        {
            numero.ValidarEnteroPositivo();
        }

        [TestMethod]
        [ExpectedException(typeof(NumeroInvalidoException))]
        [DataRow("-10")]
        [DataRow("0")]
        public void ValidarEnteroPositivo_CuandoNumeroEsNegativo_LanzoExcepcion(string numero)
        {
            numero.ValidarEnteroPositivo();
        }

        [TestMethod]
        [ExpectedException(typeof(NumeroInvalidoException))]
        [DataRow("10", -10)]
        [DataRow("10", 0)]
        public void ValidarEnteroPositivo_CuandoLongitudNoEsMayorACero_LanzoExcepcion(string numero, int longitud)
        {
            numero.ValidarEnteroPositivo(longitud);
        }

        [TestMethod]
        [ExpectedException(typeof(NumeroInvalidoException))]
        [DataRow("1234567", 8)]
        [DataRow("123456789", 8)]
        public void ValidarEnteroPositivo_CuandoNumeroNoCumpleLaLongitud_LanzoExcepcion(string numero, int longitud)
        {
            numero.ValidarEnteroPositivo(longitud);
        }

        [TestMethod]
        [DataRow("12345678")]
        public void ValidarEnteroPositivo_CuandoNumeroCumpleLosRequisitosSinLongitud_RetornoTrue(string numero)
        {
            bool valorEsperado;
            valorEsperado = numero.ValidarEnteroPositivo();
            Assert.IsTrue(valorEsperado);
        }

        [TestMethod]
        [DataRow("12345678", 8)]
        public void ValidarEnteroPositivo_CuandoNumeroCumpleLosRequisitosConLongitud_RetornoTrue(string numero, int longitud)
        {
            bool valorEsperado;
            valorEsperado = numero.ValidarEnteroPositivo(longitud);
            Assert.IsTrue(valorEsperado);
        }
    }
}
