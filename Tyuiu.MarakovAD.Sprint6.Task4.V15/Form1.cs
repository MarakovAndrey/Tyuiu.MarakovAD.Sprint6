using Tyuiu.MarakovAD.Sprint6.Task4.V15.Lib;
namespace Tyuiu.MarakovAD.Sprint6.Task4.V15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxDone.Text);
                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes) { 
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int StartStep = Convert.ToInt32(textBoxStart.Text);
                int EndStep = Convert.ToInt32(textBoxEnd.Text);
                int len = ds.GetMassFunction(StartStep, EndStep).Length;
                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(StartStep, EndStep);
                this.chart1.ChartAreas[0].AxisX.Title = "Ось X";
                this.chart1.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxDone.Text = "";
                chart1.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chart1.Series[0].Points.AddXY(StartStep, valueArray[i]);
                    textBoxDone.AppendText(valueArray[i] + Environment.NewLine);
                    StartStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИБКС-Б-25-1 Мараков Андрей", "Информация", MessageBoxButtons.OK);
        }
    }
}
