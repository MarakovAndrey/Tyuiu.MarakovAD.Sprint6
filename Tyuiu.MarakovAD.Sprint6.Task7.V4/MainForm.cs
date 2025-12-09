using System.IO;
using Tyuiu.MarakovAD.Sprint6.Task7.V4.Lib;
namespace Tyuiu.MarakovAD.Sprint6.Task7.V4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            openFileDialogTask.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath) {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;
            int[,] arrayalues = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] line_i = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrayalues[i, j] = Convert.ToInt32(line_i[j]);
                }
            }
            return arrayalues;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void buttonTake_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;

            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInput.ColumnCount = columns;
            dataGridViewInput.RowCount = rows;
            dataGridViewOutput.ColumnCount = columns;
            dataGridViewOutput.RowCount = rows;

            for (int i = 0; i < columns; i++) {
                dataGridViewInput.Columns[i].Width = 25;
                dataGridViewOutput.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < columns; j++) {
                    dataGridViewInput.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonMake.Enabled = true;
        }

        private void buttonMake_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < rows; j++)
                {
                    dataGridViewOutput.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            buttonSave.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix.ShowDialog();

            string path = saveFileDialogMatrix.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists) { 
                File.Delete(path);
            }


        }

    }
}
