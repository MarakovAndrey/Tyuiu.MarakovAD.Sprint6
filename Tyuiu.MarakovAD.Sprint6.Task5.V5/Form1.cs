using Tyuiu.MarakovAD.Sprint6.Task5.V5.Lib;
namespace Tyuiu.MarakovAD.Sprint6.Task5.V5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = "C:/DataSprint5/InPutFileTask5V5.txt";
        private void buttonDone_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Width = 20;
            dataGridView1.Columns[1].Width = 50;
            this.chart1.ChartAreas[0].AxisX.Title = "Ось X";
            this.chart1.ChartAreas[0].AxisY.Title = "Ось Y";
            chart1.Series[0].Points.Clear();
            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridView1.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chart1.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИБКС-Б-25-1 Мараков Андрей", "Информация", MessageBoxButtons.OK);
        }
    }
}
