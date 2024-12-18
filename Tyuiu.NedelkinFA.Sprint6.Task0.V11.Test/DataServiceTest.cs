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
            double result = ds.Calculate(2);
            double expected = 1.6 * Math.Pow(2, 3) - 2.1 * Math.Pow(2, 2) + 7 * 2;
            Assert.AreEqual(Math.Round(expected, 3), result);
        }
    }
}
