using Tyuiu.MarakovAD.Sprint6.Task1.V17.Lib;
namespace Tyuiu.MarakovAD.Sprint6.Task1.V17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelTask_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxTask_Enter(object sender, EventArgs e)
        {

        }

        DataService ds = new DataService();

        private void buttonDO_Click(object sender, EventArgs e)
        {
            try
            {
                int StartStep = Convert.ToInt32(textBoxStart.Text);
                int EndStep = Convert.ToInt32(textBoxEnd.Text);
                string strLine;
                int len = ds.GetMassFunction(StartStep, EndStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(StartStep, EndStep);
                textBoxResult.Text = "";
                textBoxResult.AppendText("+--------+--------+" + Environment.NewLine);
                textBoxResult.AppendText("+   X       +   f(x)     +" + Environment.NewLine);
                textBoxResult.AppendText("+--------+--------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}   |  {1, 5:f2}  | ", StartStep, valueArray[i]);
                    textBoxResult.AppendText(strLine + Environment.NewLine);
                    StartStep++;
                }
                textBoxResult.AppendText("+--------+--------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИБКС-Б-25-1 Мараков Андрей", "Информация", MessageBoxButtons.OK);
        }
    }
}
