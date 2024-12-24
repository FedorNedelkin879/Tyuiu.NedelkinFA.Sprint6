using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NedelkinFA.Sprint6.Task2.V15.Lib
{
    public class DataService : ISprint6Task2V15
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = x + 1.2;
                double y;

                if (denominator == 0)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Round(
                        (2 * Math.Sin(x) / denominator) +
                        Math.Cos(x) -
                        (7 * x * 2),
                        2
                    );
                }

                valueArray[count] = y;
                count++;
            }

            return valueArray;
        }
    }
}
