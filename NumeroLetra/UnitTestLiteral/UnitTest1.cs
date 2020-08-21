using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumeroLetra.Controllers;

namespace UnitTestLiteral
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLiteral1()
        {
            //Arrange
            LiteralController literalController = new LiteralController();
            int x = 9;
            string esperado = "NUEVE CON 0/100";

            //Act
            string resultado = literalController.LiteralGet(x);

            //Assert
            Assert.AreEqual(esperado, resultado);
        }
    }
}
