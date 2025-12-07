namespace Tyuiu.MarakovAD.Sprint6.Task3.V9
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
            groupBoxTask = new GroupBox();
            dataGridViewTask = new DataGridView();
            labelTask = new Label();
            buttonDone = new Button();
            buttonInfo = new Button();
            groupBoxRes = new GroupBox();
            dataGridViewResult = new DataGridView();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTask).BeginInit();
            groupBoxRes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(dataGridViewTask);
            groupBoxTask.Controls.Add(labelTask);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(575, 426);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // dataGridViewTask
            // 
            dataGridViewTask.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTask.ColumnHeadersVisible = false;
            dataGridViewTask.Location = new Point(285, 19);
            dataGridViewTask.Name = "dataGridViewTask";
            dataGridViewTask.RowHeadersVisible = false;
            dataGridViewTask.Size = new Size(274, 390);
            dataGridViewTask.TabIndex = 1;
            // 
            // labelTask
            // 
            labelTask.Location = new Point(6, 19);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(283, 164);
            labelTask.TabIndex = 1;
            labelTask.Text = "Дан массив 5 на 5 элементов. Выполнить сортировку по возрастанию в пятом столбце.\r\n-14  25  26  18  17\r\n\r\n  28  10   6  -2   4\r\n\r\n  30  25  -3  11 -10\r\n\r\n  11  32  -5 -20  25\r\n\r\n   2 -18  11   8 -20";
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(698, 383);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(90, 55);
            buttonDone.TabIndex = 1;
            buttonDone.Text = "Выполнитть";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(602, 383);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(90, 55);
            buttonInfo.TabIndex = 1;
            buttonInfo.Text = "Справка";
            buttonInfo.UseVisualStyleBackColor = true;
            // 
            // groupBoxRes
            // 
            groupBoxRes.Controls.Add(dataGridViewResult);
            groupBoxRes.Location = new Point(593, 12);
            groupBoxRes.Name = "groupBoxRes";
            groupBoxRes.Size = new Size(195, 365);
            groupBoxRes.TabIndex = 0;
            groupBoxRes.TabStop = false;
            groupBoxRes.Text = "Вывод данных";
            groupBoxRes.Enter += groupBox1_Enter;
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.ColumnHeadersVisible = false;
            dataGridViewResult.Location = new Point(6, 22);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.RowHeadersVisible = false;
            dataGridViewResult.Size = new Size(180, 324);
            dataGridViewResult.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonInfo);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxRes);
            Controls.Add(groupBoxTask);
            Name = "Form1";
            Text = "Sprint6 | Task3 | V9 | MarakovAD";
            Load += Form1_Load;
            groupBoxTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTask).EndInit();
            groupBoxRes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private Label labelTask;
        private DataGridView dataGridViewTask;
        private Button buttonDone;
        private Button buttonInfo;
        private GroupBox groupBoxRes;
        private DataGridView dataGridViewResult;
        private Label labelResult;
    }
}
