using Tyuiu.MarakovAD.Sprint6.Task6.V23.Lib;
namespace Tyuiu.MarakovAD.Sprint6.Task6.V23
{
    public partial class MainForm : Form
    {
        string openFilePath;
        DataService ds = new DataService();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void buttonIN_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFilePath = openFileDialog1.FileName;
            textBoxOPENED.Text = File.ReadAllText(openFilePath);
            groupBoxOut.Text = groupBoxInput.Text + " " + openFileDialog1.FileName;
            buttonDO.Enabled = true;
        }
        private void buttonDO_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = ds.CollectTextFromFile(openFilePath);
        }
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
