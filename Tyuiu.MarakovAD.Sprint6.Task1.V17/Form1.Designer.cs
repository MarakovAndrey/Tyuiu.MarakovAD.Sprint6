namespace Tyuiu.MarakovAD.Sprint6.Task1.V17
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBoxTask = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBoxResult = new GroupBox();
            textBoxResult = new TextBox();
            labelRes = new Label();
            groupBoxInput = new GroupBox();
            textBoxEnd = new TextBox();
            textBoxStart = new TextBox();
            labelEnd = new Label();
            labelStart = new Label();
            buttonDO = new Button();
            buttonInfo = new Button();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxResult.SuspendLayout();
            groupBoxInput.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(pictureBox1);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(533, 285);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            groupBoxTask.Enter += groupBoxTask_Enter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(590, 206);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Controls.Add(labelRes);
            groupBoxResult.Location = new Point(551, 12);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(237, 413);
            groupBoxResult.TabIndex = 0;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод данных";
            groupBoxResult.Enter += groupBoxTask_Enter;
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = SystemColors.Control;
            textBoxResult.Cursor = Cursors.IBeam;
            textBoxResult.Location = new Point(6, 37);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(225, 361);
            textBoxResult.TabIndex = 1;
            // 
            // labelRes
            // 
            labelRes.AutoSize = true;
            labelRes.Location = new Point(6, 19);
            labelRes.Name = "labelRes";
            labelRes.Size = new Size(63, 15);
            labelRes.TabIndex = 0;
            labelRes.Text = "Результат:";
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(textBoxEnd);
            groupBoxInput.Controls.Add(textBoxStart);
            groupBoxInput.Controls.Add(labelEnd);
            groupBoxInput.Controls.Add(labelStart);
            groupBoxInput.Location = new Point(12, 318);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(326, 107);
            groupBoxInput.TabIndex = 0;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных";
            groupBoxInput.Enter += groupBoxTask_Enter;
            // 
            // textBoxEnd
            // 
            textBoxEnd.Location = new Point(178, 47);
            textBoxEnd.Name = "textBoxEnd";
            textBoxEnd.Size = new Size(120, 23);
            textBoxEnd.TabIndex = 1;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(18, 47);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(120, 23);
            textBoxStart.TabIndex = 1;
            // 
            // labelEnd
            // 
            labelEnd.AutoSize = true;
            labelEnd.Location = new Point(178, 29);
            labelEnd.Name = "labelEnd";
            labelEnd.Size = new Size(75, 15);
            labelEnd.TabIndex = 0;
            labelEnd.Text = "Конец шага:";
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Location = new Point(18, 29);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(72, 15);
            labelStart.TabIndex = 0;
            labelStart.Text = "Старт шага:";
            // 
            // buttonDO
            // 
            buttonDO.BackColor = Color.FromArgb(255, 192, 128);
            buttonDO.Location = new Point(429, 329);
            buttonDO.Name = "buttonDO";
            buttonDO.Size = new Size(116, 92);
            buttonDO.TabIndex = 1;
            buttonDO.Text = "Выполнить";
            buttonDO.UseVisualStyleBackColor = false;
            buttonDO.Click += buttonDO_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.BackColor = Color.FromArgb(255, 192, 255);
            buttonInfo.Location = new Point(344, 329);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(79, 92);
            buttonInfo.TabIndex = 1;
            buttonInfo.Text = "Справка";
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonInfo);
            Controls.Add(buttonDO);
            Controls.Add(groupBoxResult);
            Controls.Add(groupBoxInput);
            Controls.Add(groupBoxTask);
            Name = "Form1";
            Text = "Sprint6 | Task1 | V17 | MarakovAD";
            groupBoxTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private PictureBox pictureBox1;
        private GroupBox groupBoxResult;
        private TextBox textBoxResult;
        private Label labelRes;
        private GroupBox groupBoxInput;
        private TextBox textBoxEnd;
        private TextBox textBoxStart;
        private Label labelEnd;
        private Label labelStart;
        private Button buttonDO;
        private Button buttonInfo;
    }
}
