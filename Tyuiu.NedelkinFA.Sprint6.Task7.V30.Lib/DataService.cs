using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NedelkinFA.Sprint6.Task7.V30.Lib
{
    public class DataService : ISprint6Task7V30
    {
        public int[,] GetMatrix(string path)
        {
            string[] file = File.ReadAllLines(path);
            int[,] matrix = new int[file.Length, file[0].Split(';').Length];

            for (int i = 0; i < file.Length; i++)
            {
                string[] line = file[i].Split(';');

                for (int j = 0; j < line.Length; j++)
                {
                    matrix[i, j] = Convert.ToInt32(line[j]);
                }
            }

            return matrix;
        }
    }
}
