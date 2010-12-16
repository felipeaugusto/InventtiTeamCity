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
        public void DeveSomarCorretamente()
        {
            calculadora.Soma(1, 1).Should().Be(2);
        }
    }
}
