namespace Tyuiu.MarakovAD.Sprint6.Task6.V23
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            buttonInfo = new Button();
            buttonDO = new Button();
            buttonIN = new Button();
            groupBoxTask = new GroupBox();
            labelTask = new Label();
            panel2 = new Panel();
            groupBoxInput = new GroupBox();
            textBoxOPENED = new TextBox();
            panel3 = new Panel();
            groupBoxOut = new GroupBox();
            textBoxResult = new TextBox();
            splitter1 = new Splitter();
            openFileDialog1 = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            groupBoxTask.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxInput.SuspendLayout();
            panel3.SuspendLayout();
            groupBoxOut.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(buttonInfo);
            panel1.Controls.Add(buttonDO);
            panel1.Controls.Add(buttonIN);
            panel1.Controls.Add(groupBoxTask);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 109);
            panel1.TabIndex = 0;
            // 
            // buttonInfo
            // 
            buttonInfo.BackColor = Color.Yellow;
            buttonInfo.Location = new Point(708, 5);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(66, 46);
            buttonInfo.TabIndex = 1;
            buttonInfo.Text = "Info";
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += this.buttonInfo_Click;
            // 
            // buttonDO
            // 
            buttonDO.Location = new Point(114, 8);
            buttonDO.Name = "buttonDO";
            buttonDO.Size = new Size(105, 43);
            buttonDO.TabIndex = 1;
            buttonDO.Text = "DO";
            buttonDO.UseVisualStyleBackColor = true;
            buttonDO.Click += buttonDO_Click;
            // 
            // buttonIN
            // 
            buttonIN.Location = new Point(3, 7);
            buttonIN.Name = "buttonIN";
            buttonIN.Size = new Size(105, 43);
            buttonIN.TabIndex = 1;
            buttonIN.Text = "IN";
            toolTip1.SetToolTip(buttonIN, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonIN.UseVisualStyleBackColor = true;
            buttonIN.Click += buttonIN_Click;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(labelTask);
            groupBoxTask.Location = new Point(3, 52);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(778, 51);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // labelTask
            // 
            labelTask.AutoSize = true;
            labelTask.Location = new Point(9, 19);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(487, 15);
            labelTask.TabIndex = 0;
            labelTask.Text = "Загрузить текстовый файл в textboxIn, выполнить действия и вывести итог в textboxOut";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(groupBoxInput);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(405, 302);
            panel2.TabIndex = 1;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(textBoxOPENED);
            groupBoxInput.Location = new Point(6, 6);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(393, 284);
            groupBoxInput.TabIndex = 0;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод";
            // 
            // textBoxOPENED
            // 
            textBoxOPENED.Location = new Point(6, 22);
            textBoxOPENED.Multiline = true;
            textBoxOPENED.Name = "textBoxOPENED";
            textBoxOPENED.ReadOnly = true;
            textBoxOPENED.Size = new Size(381, 256);
            textBoxOPENED.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(groupBoxOut);
            panel3.Controls.Add(splitter1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(405, 109);
            panel3.Name = "panel3";
            panel3.Size = new Size(379, 302);
            panel3.TabIndex = 2;
            // 
            // groupBoxOut
            // 
            groupBoxOut.Controls.Add(textBoxResult);
            groupBoxOut.Location = new Point(9, 6);
            groupBoxOut.Name = "groupBoxOut";
            groupBoxOut.Size = new Size(358, 284);
            groupBoxOut.TabIndex = 0;
            groupBoxOut.TabStop = false;
            groupBoxOut.Text = "Вывод";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(6, 22);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(346, 256);
            textBoxResult.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 302);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Подсказка";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(800, 450);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sprint6 | Task6 | V23 | MarakovAD";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            panel2.ResumeLayout(false);
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            panel3.ResumeLayout(false);
            groupBoxOut.ResumeLayout(false);
            groupBoxOut.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Splitter splitter1;
        private GroupBox groupBoxTask;
        private Label labelTask;
        private Button buttonInfo;
        private Button buttonDO;
        private Button buttonIN;
        private GroupBox groupBoxInput;
        private TextBox textBoxOPENED;
        private GroupBox groupBoxOut;
        private TextBox textBoxResult;
        private ToolTip toolTip1;
        private OpenFileDialog openFileDialog1;
    }
}
