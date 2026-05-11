using ClassLibrary;
namespace TestProject
{
    [TestClass]
    public sealed class Test1
    {
        private Class1 lib;
        [TestInitialize]
        public void Setup()
        {
            lib = new Class1();
        }
        [TestMethod]
        public void TestMethod1()
        {
            double n = lib.Addition(1, 2);
            Assert.AreEqual(n, 3);        
        }
    }
}
