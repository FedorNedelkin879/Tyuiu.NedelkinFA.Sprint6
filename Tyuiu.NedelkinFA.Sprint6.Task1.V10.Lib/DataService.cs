using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NedelkinFA.Sprint6.Task1.V10.Lib
{
    public class DataService : ISprint6Task1V10
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] res = new double[len];
            int count = 0;

            for (int i = startValue; i <= stopValue; i++)
            {
                double denominator = 3 * i + 0.5;
                double y;

                if (denominator == 0)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Round(
                        Math.Sin(i) +
                        (2 / denominator) -
                        (2 * Math.Cos(i) * 2 * i),
                        2
                    );
                }

                res[count] = y;
                count++;
            }

            return res;
        }
    }
}
