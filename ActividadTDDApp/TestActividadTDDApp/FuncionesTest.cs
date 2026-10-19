namespace TestActividadTDDApp
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void FactorialNumeroNegativo()
        {
            int reulstado = Test1.CalcularFactorial(-5);
            Assert.AreEqual(-1, reulstado);
        }
        [TestMethod]
        public void FactorialCero()
        {
            int reulstado = Test1.CalcularFactorial(0);
            Assert.AreEqual(1, reulstado);
        }
        [TestMethod]
        public void FactorialCorrecto()
        {
            int reulstado = Test1.CalcularFactorial(5);
            Assert.AreEqual(120, reulstado);
        }
    }
}
