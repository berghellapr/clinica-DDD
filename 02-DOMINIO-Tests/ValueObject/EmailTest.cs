using Xunit;
using _02_DOMINIO.ValueObject;

namespace _02_DOMINIO_Tests.ValueObject
{
    public class EmailTest
    {
        [Fact]
        public void Email_ConEmailValido_ConInstanciaEmail()
        {
            //arrange
            string email = "ejemplo@test.com";

            //act
            Exception excepcion = Record.Exception(() => 
            { 
                Email emailInstanciado = new Email(email);
                Assert.NotNull(emailInstanciado);
                Assert.Equal(email, emailInstanciado.Valor());
            });

            //assert
            Assert.Null(excepcion);
        }

        [Fact]
        public void Email_ConEmailValido_NoDebeLanzarExcepcion()
        {
            //arrange
            string email = "ejemplo@test.com";

            //act
            var excepcion = Record.Exception(() => new Email(email));

            //assert
            Assert.Null(excepcion);
        }

        [Fact]
        public void Email_ConEmailNoValido_DebeLanzarExcepcion()
        {
            //arrange
            string email = "ejemplo-no-valido";

            //act
            var excepcion = Assert.Throws<ArgumentException>(() => new Email(email));

            //assert
            Assert.Equal("El email no es válido.", excepcion.Message);
        }
    }
}