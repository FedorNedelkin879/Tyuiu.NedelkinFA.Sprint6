using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NedelkinFA.Sprint6.Task2.V15.Lib
{
    public class DataService : ISprint6Task2V15
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue + 1);
            valueArray = new double[len];
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = 3 * x + 1.2;
                if (denominator == 0)
                {
                    valueArray[count] = 0;
                    continue;
                }

                double y = Math.Round(
                    (2 * Math.Sin(x)) / denominator +
                    Math.Cos(x) -
                    (7 * x * x),
                    2
                );
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
