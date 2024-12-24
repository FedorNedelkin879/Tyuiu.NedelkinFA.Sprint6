using Tyuiu.NedelkinFA.Sprint6.Task2.V15.Lib;

namespace Tyuiu.NedelkinFA.Sprint6.Task2.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] res = ds.GetMassFunction(startValue, stopValue);

            double[] expectedResults = new double[]
            {70.14, 55.21, 41.05, 27.96, 15.48, 1.0, -13.06, -28.16, -42.96, -56.77, -69.83};

            for (int i = 0; i < res.Length; i++)
            {
                Assert.AreEqual(res[i], expectedResults[i], 0.01);
            }
        }
    }
}
