namespace Tyuiu.MarakovAD.Sprint6.Task4.V15
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxTask = new GroupBox();
            labelTask = new Label();
            groupBoxInput = new GroupBox();
            textBoxEnd = new TextBox();
            textBoxStart = new TextBox();
            labelEnd = new Label();
            labelStart = new Label();
            buttonDone = new Button();
            buttonInfo = new Button();
            buttonSave = new Button();
            groupBoxDone = new GroupBox();
            textBoxDone = new TextBox();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxTask.SuspendLayout();
            groupBoxInput.SuspendLayout();
            groupBoxDone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(labelTask);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(432, 66);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // labelTask
            // 
            labelTask.Location = new Point(6, 19);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(420, 44);
            labelTask.TabIndex = 1;
            labelTask.Text = "Написать программу, которая табулирует функцию и выводит результат на textbox и сохраняет в блокнот";
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(textBoxEnd);
            groupBoxInput.Controls.Add(textBoxStart);
            groupBoxInput.Controls.Add(labelEnd);
            groupBoxInput.Controls.Add(labelStart);
            groupBoxInput.Location = new Point(459, 12);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(233, 66);
            groupBoxInput.TabIndex = 0;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных";
            // 
            // textBoxEnd
            // 
            textBoxEnd.Location = new Point(122, 37);
            textBoxEnd.Name = "textBoxEnd";
            textBoxEnd.Size = new Size(100, 23);
            textBoxEnd.TabIndex = 2;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(6, 37);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(100, 23);
            textBoxStart.TabIndex = 2;
            // 
            // labelEnd
            // 
            labelEnd.Location = new Point(122, 19);
            labelEnd.Name = "labelEnd";
            labelEnd.Size = new Size(77, 18);
            labelEnd.TabIndex = 1;
            labelEnd.Text = "Конец шага:";
            // 
            // labelStart
            // 
            labelStart.Location = new Point(6, 19);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(77, 18);
            labelStart.TabIndex = 1;
            labelStart.Text = "Старт шага:";
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.Blue;
            buttonDone.ForeColor = Color.Chocolate;
            buttonDone.Location = new Point(698, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(120, 63);
            buttonDone.TabIndex = 1;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.BackColor = Color.Black;
            buttonInfo.ForeColor = SystemColors.ButtonShadow;
            buttonInfo.Location = new Point(966, 12);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(84, 63);
            buttonInfo.TabIndex = 1;
            buttonInfo.Text = "Справка";
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += buttonInfo_Click_1;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = SystemColors.ActiveBorder;
            buttonSave.ForeColor = Color.BlanchedAlmond;
            buttonSave.Location = new Point(834, 12);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(84, 60);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // groupBoxDone
            // 
            groupBoxDone.Controls.Add(textBoxDone);
            groupBoxDone.Location = new Point(12, 84);
            groupBoxDone.Name = "groupBoxDone";
            groupBoxDone.Size = new Size(173, 453);
            groupBoxDone.TabIndex = 0;
            groupBoxDone.TabStop = false;
            groupBoxDone.Text = "Вывод";
            // 
            // textBoxDone
            // 
            textBoxDone.Location = new Point(6, 22);
            textBoxDone.Multiline = true;
            textBoxDone.Name = "textBoxDone";
            textBoxDone.ReadOnly = true;
            textBoxDone.Size = new Size(161, 425);
            textBoxDone.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(191, 84);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(858, 453);
            chart1.TabIndex = 2;
            chart1.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "График функции";
            chart1.Titles.Add(title1);
            chart1.Click += chart1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 549);
            Controls.Add(chart1);
            Controls.Add(buttonSave);
            Controls.Add(buttonInfo);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxInput);
            Controls.Add(groupBoxDone);
            Controls.Add(groupBoxTask);
            Name = "Form1";
            Text = "Sprint6 | Task4 | V15 | MarakovAD";
            groupBoxTask.ResumeLayout(false);
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            groupBoxDone.ResumeLayout(false);
            groupBoxDone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private Label labelTask;
        private GroupBox groupBoxInput;
        private TextBox textBoxStart;
        private Label labelEnd;
        private Label labelStart;
        private TextBox textBoxEnd;
        private Button buttonDone;
        private Button buttonInfo;
        private Button buttonSave;
        private GroupBox groupBoxDone;
        private TextBox textBoxDone;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
