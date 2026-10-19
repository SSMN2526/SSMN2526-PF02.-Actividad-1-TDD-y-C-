using ActividadTDDApp;

namespace TestActividadTDDApp
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void FactorialNumeroNegativo()
        {
            int reulstado = Funciones.CalcularFactorial(-5);
            Assert.AreEqual(-1, reulstado);
        }
        [TestMethod]
        public void FactorialCero()
        {
            int reulstado = Funciones.CalcularFactorial(0);
            Assert.AreEqual(1, reulstado);
        }
        [TestMethod]
        public void FactorialCorrecto()
        {
            int reulstado = Funciones.CalcularFactorial(5);
            Assert.AreEqual(120, reulstado);
        }
    }
}
