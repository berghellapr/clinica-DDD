using Xunit;
using _02_DOMINIO.ValueObject;

namespace _02_DOMINIO_Tests.ValueObject
{
    public class ApellidoTest
    {
        [Fact]
        public void Apellido_ConValorValido_SinExcepciones()
        {
            //arrange
            string apellido = "Ejemplo";

            //act
            var excepcion = Record.Exception(() => new Apellido(apellido));

            //assert
            Assert.Null(excepcion);
        }

        [Fact]
        public void Apellido_ConValorCorto_DebeLanzarExcepcion()
        {
            //arrange
            string apellido = "Ej";
            string mensajeEsperado = "El apellido debe contener, al menos, 4 caracteres.";

            //act
            var excepcion = Record.Exception(() => new Apellido(apellido));

            //assert
            Assert.Equal(mensajeEsperado, excepcion.Message);
        }

        [Fact]
        public void Apellido_ConValorLargo_DebeLanzarExcepcion()
        {
            //arrange
            string apellido = "EjemploDemasiadoDemasiadoLargo";
            string mensajeEsperado = "El apellido debe contener un máximo de 20 caracteres.";

            //act
            var excepcion = Record.Exception(() => new Apellido(apellido));

            //assert
            Assert.Equal(mensajeEsperado, excepcion.Message);
        }
    }
}
