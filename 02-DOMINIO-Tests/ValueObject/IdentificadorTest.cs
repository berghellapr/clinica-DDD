using Xunit;
using _02_DOMINIO.ValueObject;

namespace _02_DOMINIO_Tests.ValueObject
{
    public class IdentificadorTest
    {
        [Fact]
        public void Identificador_ConInstanciaValida_DebeRetornarValor()
        {
            //arrange
            Guid id = Guid.NewGuid();
            Identificador identificador = new Identificador(id);

            //act
            Guid valorObtenido = identificador.Valor();

            //assert
            Assert.Equal(id, valorObtenido);
        }

        [Fact]
        public void Identificador_IgualdadEntre2InstanciasConMismoValor_DebenSerIguales()
        {
            //arrange
            Guid id = Guid.NewGuid();
            Identificador identificador1 = new Identificador(id);
            Identificador identificador2 = new Identificador(id);

            //act
            bool sonIguales = identificador1.Valor().ToString() == identificador2.Valor().ToString();

            //assert
            Assert.True(sonIguales);
        }

        [Fact]
        public void Identificador_IgualdadEntre2InstanciasConDiferenteValor_DebenSerDiferentes()
        {
            //arrange
            Guid id1 = Guid.NewGuid();
            Guid id2 = Guid.NewGuid();
            Identificador identificador1 = new Identificador(id1);
            Identificador identificador2 = new Identificador(id2);

            //act
            bool sonDiferentes = !identificador1.Equals(identificador2);

            //assert
            Assert.True(sonDiferentes);
        }
    }
}