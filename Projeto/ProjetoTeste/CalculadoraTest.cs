using NUnit.Framework;
using SharpTestsEx;
using Projeto;

namespace ProjetoTeste
{
    [TestFixture]
    public class CalculadoraTest
    {

        private Calculadora calculadora;

        [SetUp]
        public void Setup()
        {
            calculadora = new Calculadora();
        }

        [Test]
        public void DeveSomarCorretamenteNumerosPositivos()
        {
            calculadora.Soma(1, 1).Should().Be(2);
        }

        [Test]
        public void DeveSomarCorretamenteNumerosNegativos()
        {
            calculadora.Soma(-1, -1).Should().Be(-2);
        }

        [Test]
        public void DeveSomarCorretamenteNumeroPositivoComNegativo()
        {
            calculadora.Soma(2, -2).Should().Be(0);
        }
    }
}
