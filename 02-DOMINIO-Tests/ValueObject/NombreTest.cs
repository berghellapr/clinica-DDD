using Xunit;
using _02_DOMINIO.ValueObject;

namespace _02_DOMINIO_Tests.ValueObject
{
    public class NombreTest
    {
        [Fact]
        public void Nombre_ConValorValido_SinExcepciones()
        {
            //arrange
            string nombre = "Ejemplo";

            //act
            var excepcion = Record.Exception(() => new Nombre (nombre));

            //assert
            Assert.Null(excepcion);
        }

        [Fact]
        public void Nombre_ConValorCorto_DebeLanzarExcepcion()
        {
            //arrange
            string nombre = "Ej";
            string mensajeEsperado = "El nombre debe contener, al menos, 4 caracteres.";

            //act
            var excepcion = Record.Exception(() => new Nombre(nombre));

            //assert
            Assert.Equal(mensajeEsperado, excepcion.Message);
        }

        [Fact]
        public void Nombre_ConValorLargo_DebeLanzarExcepcion()
        {
            //arrange
            string nombre = "EjemploDemasiadoDemasiadoLargo";
            string mensajeEsperado = "El nombre debe contener un máximo de 20 caracteres.";

            //act
            var excepcion = Record.Exception(() => new Nombre(nombre));

            //assert
            Assert.Equal(mensajeEsperado, excepcion.Message);
        }
    }
}