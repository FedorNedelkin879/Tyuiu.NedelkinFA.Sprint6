using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NedelkinFA.Sprint6.Task3.V11.Lib
{
    public class DataService : ISprint6Task3V11
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            int[] firstColumn = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                firstColumn[i] = matrix[i, 0];
            }
            Array.Sort(firstColumn);

            for (int i = 0; i < rows; i++)
            {
                matrix[i, 0] = firstColumn[i];
            }

            return matrix;
        }
    }
}
