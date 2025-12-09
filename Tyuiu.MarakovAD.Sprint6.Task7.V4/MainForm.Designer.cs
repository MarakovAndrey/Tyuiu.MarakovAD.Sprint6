namespace Tyuiu.MarakovAD.Sprint6.Task7.V4
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            buttonInfo = new Button();
            buttonSave = new Button();
            buttonMake = new Button();
            buttonTake = new Button();
            panel2 = new Panel();
            groupBoxTask = new GroupBox();
            labelTask = new Label();
            panel3 = new Panel();
            groupBoxInput = new GroupBox();
            dataGridViewInput = new DataGridView();
            panel4 = new Panel();
            groupBoxOutput = new GroupBox();
            dataGridViewOutput = new DataGridView();
            splitter1 = new Splitter();
            openFileDialogTask = new OpenFileDialog();
            saveFileDialogMatrix = new SaveFileDialog();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxTask.SuspendLayout();
            panel3.SuspendLayout();
            groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput).BeginInit();
            panel4.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonInfo);
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonMake);
            panel1.Controls.Add(buttonTake);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 76);
            panel1.TabIndex = 0;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(857, 3);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(124, 67);
            buttonInfo.TabIndex = 0;
            buttonInfo.Text = "Справка";
            buttonInfo.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Enabled = false;
            buttonSave.Location = new Point(263, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(124, 67);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonMake
            // 
            buttonMake.Enabled = false;
            buttonMake.Location = new Point(133, 3);
            buttonMake.Name = "buttonMake";
            buttonMake.Size = new Size(124, 67);
            buttonMake.TabIndex = 0;
            buttonMake.Text = "Выполнить";
            buttonMake.UseVisualStyleBackColor = true;
            buttonMake.Click += buttonMake_Click;
            // 
            // buttonTake
            // 
            buttonTake.Location = new Point(3, 3);
            buttonTake.Name = "buttonTake";
            buttonTake.Size = new Size(124, 67);
            buttonTake.TabIndex = 0;
            buttonTake.Text = "Добавить";
            buttonTake.UseVisualStyleBackColor = true;
            buttonTake.Click += buttonTake_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxTask);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(984, 100);
            panel2.TabIndex = 1;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(labelTask);
            groupBoxTask.Location = new Point(3, 6);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(978, 88);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // labelTask
            // 
            labelTask.Location = new Point(6, 19);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(963, 56);
            labelTask.TabIndex = 0;
            labelTask.Text = "Дан файл в формате .csv с матрицей, вывести её на экран, выполнить действия и вывести на второй текст бокс, добавить возможность сохранить результат";
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBoxInput);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 176);
            panel3.Name = "panel3";
            panel3.Size = new Size(482, 335);
            panel3.TabIndex = 2;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(dataGridViewInput);
            groupBoxInput.Location = new Point(6, 6);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(470, 317);
            groupBoxInput.TabIndex = 0;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод";
            // 
            // dataGridViewInput
            // 
            dataGridViewInput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput.Location = new Point(6, 22);
            dataGridViewInput.Name = "dataGridViewInput";
            dataGridViewInput.Size = new Size(458, 289);
            dataGridViewInput.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBoxOutput);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(488, 176);
            panel4.Name = "panel4";
            panel4.Size = new Size(496, 335);
            panel4.TabIndex = 3;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(dataGridViewOutput);
            groupBoxOutput.Location = new Point(14, 6);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(470, 317);
            groupBoxOutput.TabIndex = 0;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод";
            // 
            // dataGridViewOutput
            // 
            dataGridViewOutput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput.Location = new Point(6, 22);
            dataGridViewOutput.Name = "dataGridViewOutput";
            dataGridViewOutput.Size = new Size(458, 289);
            dataGridViewOutput.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(482, 176);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(10, 335);
            splitter1.TabIndex = 4;
            splitter1.TabStop = false;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 511);
            Controls.Add(splitter1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(1000, 550);
            Name = "MainForm";
            Text = "Sprint6| Task7 | V4 | MarakovAD";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBoxTask.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBoxInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput).EndInit();
            panel4.ResumeLayout(false);
            groupBoxOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonInfo;
        private Button buttonSave;
        private Button buttonMake;
        private Button buttonTake;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Splitter splitter1;
        private GroupBox groupBoxTask;
        private Label labelTask;
        private GroupBox groupBoxInput;
        private DataGridView dataGridViewInput;
        private GroupBox groupBoxOutput;
        private DataGridView dataGridViewOutput;
        private OpenFileDialog openFileDialogTask;
        private SaveFileDialog saveFileDialogMatrix;
    }
}
