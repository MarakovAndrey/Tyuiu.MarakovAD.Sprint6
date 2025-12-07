using System.ComponentModel.DataAnnotations;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MarakovAD.Sprint6.Task3.V9.Lib
{
    public class DataService : ISprint6Task3V9
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            for (int i = 0; i < rows-1; i++) {
                int minIn = i;
                for (int j = i + 1; j < rows; j++) {
                    if (matrix[j, 4] < matrix[minIn, 4]) { 
                        minIn = j;
                    }
                }
                int temp = matrix[i, 4];
                matrix[i,4] = matrix[minIn, 4];
                matrix[minIn,4] = temp;
            }
            return matrix;
        }
    }
}
