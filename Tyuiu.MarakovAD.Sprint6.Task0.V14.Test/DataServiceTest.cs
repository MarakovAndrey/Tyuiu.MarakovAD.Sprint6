using Tyuiu.MarakovAD.Sprint6.Task0.V14.Lib;
namespace Tyuiu.MarakovAD.Sprint6.Task0.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            double res = ds.Calculate(x);
            double wait = -0.444;
            Assert.AreEqual(res, wait);
        }
    }
}
