using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MarakovAD.Sprint6.Task4.V15.Lib
{
    public class DataService : ISprint6Task4V15
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
                res = Math.Round(Math.Sin(x) + 2.0 * x / 3.0 - Math.Cos(x) * 4.0 * x, 2);
                valueArray[count] = res;
                count++;
            }
            return valueArray;
        }
    }
}
