using Tyuiu.MarakovAD.Sprint6.Task3.V9.Lib;
namespace Tyuiu.MarakovAD.Sprint6.Task3.V9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { -14, 25, 26, 18, 17 }, { 28, 10, 6, -2, 4 }, { 30, 25, -3, 11, -10 }, { 11, 32, -5, -20, 25 }, { 2, -18, 11, 8, -20 } };


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] nm = ds.Calculate(mtrx);
            int rows = nm.GetUpperBound(0) + 1;
            int columns = nm.Length / rows;
            dataGridViewResult.ColumnCount = columns;
            dataGridViewResult.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    dataGridViewResult.Rows[i].Cells[j].Value = Convert.ToString(nm[i, j]);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;
            dataGridViewTask.ColumnCount = columns;
            dataGridViewTask.RowCount = rows;
            for (int i = 0; i < columns; i++) {
                dataGridViewTask.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < rows; j++)
                {
                    dataGridViewTask.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }
    }
}
