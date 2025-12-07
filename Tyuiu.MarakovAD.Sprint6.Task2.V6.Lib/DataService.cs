using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MarakovAD.Sprint6.Task2.V6.Lib
{
    public class DataService : ISprint6Task2V6
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double res;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                res = Math.Round((Math.Cos(x) / (x - 0.7)) - Math.Sin(x) * 12 * x + 2, 2);
                valueArray[count] = res;
                count++;
            }
            return valueArray;
        }
    }
}
