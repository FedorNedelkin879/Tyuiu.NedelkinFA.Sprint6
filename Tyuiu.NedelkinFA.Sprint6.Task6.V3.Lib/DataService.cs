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

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    resultList.Add(Math.Round(nums[i], 3));
                }
            }

            double[] resNums = resultList.ToArray();
            return resNums;
        }
    }
}
