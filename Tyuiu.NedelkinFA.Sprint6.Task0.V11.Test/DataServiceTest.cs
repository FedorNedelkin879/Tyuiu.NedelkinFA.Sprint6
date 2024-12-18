using Tyuiu.NedelkinFA.Sprint6.Task0.V11.Lib;

namespace Tyuiu.NedelkinFA.Sprint6.Task0.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(7, 8, 9);
            double wait = 1.667;
            Assert.AreEqual(wait, res);
        }
    }
}