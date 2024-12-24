using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NedelkinFA.Sprint6.Task5.V3.Lib
{
    public class DataService : ISprint6Task5V3
    {
        public double[] LoadFromDataFile(string path)
        {
            string[] strNum = File.ReadAllLines(path);
            double[] nums = Array.ConvertAll(strNum, double.Parse);
            List<double> resultList = new List<double>();

            foreach (double num in nums)
            {
                if (num % 1 != 0)
                {
                    resultList.Add(Math.Round(num, 3));
                }
            }

            double[] resNums = resultList.ToArray();
            return resNums;
        }
    }
}
