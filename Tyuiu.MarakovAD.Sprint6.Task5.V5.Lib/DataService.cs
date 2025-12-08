using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MarakovAD.Sprint6.Task5.V5.Lib
{
    public class DataService : ISprint6Task5V5
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path)) {
                string line;
                while ((line = reader.ReadLine()) != null) {
                    string[] token = line.Split(' ');
                    len += token.Length;
                }
            }
            double[] numsArray = new double[len];
            int index = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] token = line.Split(' ');
                    foreach (string s in token)
                    {
                        numsArray[index] = Convert.ToDouble(s.Replace('.', ','));
                        index++;
                    }
                }
            }
            numsArray = numsArray.Where(val => val % 2 == 0).ToArray();
            return numsArray;
        }
    }
}
