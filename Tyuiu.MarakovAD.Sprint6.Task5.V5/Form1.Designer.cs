namespace Tyuiu.MarakovAD.Sprint6.Task5.V5
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
            groupBoxTask = new GroupBox();
            labelTask = new Label();
            groupBoxResult = new GroupBox();
            dataGridView1 = new DataGridView();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonDone = new Button();
            buttonOpen = new Button();
            buttonInfo = new Button();
            groupBoxTask.SuspendLayout();
            groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(labelTask);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(672, 81);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // labelTask
            // 
            labelTask.Location = new Point(6, 19);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(660, 47);
            labelTask.TabIndex = 0;
            labelTask.Text = "Прочитать данные из файла и высети их в dataGridView, которые делятся на два без остатка и построить диграмму.";
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(dataGridView1);
            groupBoxResult.Location = new Point(12, 99);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(179, 437);
            groupBoxResult.TabIndex = 0;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод данных:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(167, 409);
            dataGridView1.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(197, 99);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(823, 437);
            chart1.TabIndex = 1;
            chart1.Text = "chart1";
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(690, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(108, 81);
            buttonDone.TabIndex = 2;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(804, 12);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(108, 81);
            buttonOpen.TabIndex = 2;
            buttonOpen.Text = "Открыть файл";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(918, 12);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(108, 81);
            buttonInfo.TabIndex = 2;
            buttonInfo.Text = "Справка";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 563);
            Controls.Add(buttonInfo);
            Controls.Add(buttonOpen);
            Controls.Add(buttonDone);
            Controls.Add(chart1);
            Controls.Add(groupBoxResult);
            Controls.Add(groupBoxTask);
            Name = "Form1";
            Text = "Sprint6 | Task5 | V5 | MarakovAD";
            groupBoxTask.ResumeLayout(false);
            groupBoxResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private Label labelTask;
        private GroupBox groupBoxResult;
        private DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button buttonDone;
        private Button buttonOpen;
        private Button buttonInfo;
    }
}
