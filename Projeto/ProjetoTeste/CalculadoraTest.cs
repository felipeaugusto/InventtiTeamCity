using NUnit.Framework;
using SharpTestsEx;
using Projeto;

namespace ProjetoTeste
{
    [TestFixture]
    public class CalculadoraTest
    {

        private Calculadora _calculadora;

        [SetUp]
        public void Setup()
        {
            _calculadora = new Calculadora();
        }

        [Test]
        public void DeveSomarCorretamenteNumerosPositivos()
        {
            _calculadora.Soma(1, 1).Should().Be(2);
        }

        [Test]
        public void DeveSomarCorretamenteNumerosNegativos()
        {
            _calculadora.Soma(-1, -1).Should().Be(-2);
        }

        [Test]
        public void DeveSomarCorretamenteNumeroPositivoComNegativo()
        {
            _calculadora.Soma(2, -2).Should().Be(0);
        }

        [Test]
        public void DeveSubtrairCorretamenteNumerosPositivos()
        {
            _calculadora.Subtracao(1, 1).Should().Be(0);
        }

        [Test]
        public void DeveSubtrairCorretamenteNumerosNegativos()
        {
            _calculadora.Subtracao(-1, -1).Should().Be(0);
        }

        [Test]
        public void DeveSubtrairCorretamenteNumeroPositivoComNegativo()
        {
            _calculadora.Subtracao(-1, 1).Should().Be(0);
        }
    }
}
