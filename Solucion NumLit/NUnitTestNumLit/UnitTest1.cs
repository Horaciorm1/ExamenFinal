using NumLit.Controllers;
using NUnit.Framework;

namespace NUnitTestNumLit
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestGet()
        {
            //Arrange=preparacion
            string num = "0";

            string esperado = "CERO";

            NumLitController Letra = new NumLitController();

            //Act=ejecution
            string resultado = Letra.enletras(num);

            //Assert=Verification
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestGet1()
        {
            //Arrange=preparacion
            string num = "5";

            string esperado = "CINCO";

            NumLitController Letra = new NumLitController();

            //Act=ejecution
            string resultado = Letra.enletras(num);

            //Assert=Verification
            Assert.AreEqual(esperado, resultado);

        }


    }
}