namespace Tyuiu.MarakovAD.Sprint6.Task0.V14
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupBoxInputData = new GroupBox();
            textBoxIntX = new TextBox();
            labelIntX = new Label();
            groupBoxTask = new GroupBox();
            labelTask = new Label();
            pictureBox1 = new PictureBox();
            groupBoxResult = new GroupBox();
            textBoxResult = new TextBox();
            labelResult = new Label();
            buttonDone = new Button();
            buttonHelp = new Button();
            groupBoxInputData.SuspendLayout();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxResult.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // groupBoxInputData
            // 
            groupBoxInputData.Controls.Add(textBoxIntX);
            groupBoxInputData.Controls.Add(labelIntX);
            groupBoxInputData.Location = new Point(34, 274);
            groupBoxInputData.Name = "groupBoxInputData";
            groupBoxInputData.Size = new Size(462, 105);
            groupBoxInputData.TabIndex = 1;
            groupBoxInputData.TabStop = false;
            groupBoxInputData.Text = "Ввод данных";
            // 
            // textBoxIntX
            // 
            textBoxIntX.BackColor = Color.White;
            textBoxIntX.Location = new Point(21, 57);
            textBoxIntX.Name = "textBoxIntX";
            textBoxIntX.Size = new Size(129, 23);
            textBoxIntX.TabIndex = 2;
            textBoxIntX.KeyPress += textBoxIntX_KeyPress;
            // 
            // labelIntX
            // 
            labelIntX.AutoSize = true;
            labelIntX.Location = new Point(21, 39);
            labelIntX.Name = "labelIntX";
            labelIntX.Size = new Size(90, 15);
            labelIntX.TabIndex = 2;
            labelIntX.Text = "Переменная А:";
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(labelTask);
            groupBoxTask.Location = new Point(34, 42);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(515, 211);
            groupBoxTask.TabIndex = 2;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // labelTask
            // 
            labelTask.AutoSize = true;
            labelTask.Location = new Point(6, 19);
            labelTask.MaximumSize = new Size(450, 0);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(410, 30);
            labelTask.TabIndex = 0;
            labelTask.Text = "Дано выражение вычислить его значение при x = 3, результат вывести в TextBox. Округлить до трёх знаков после запятой.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(580, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Controls.Add(labelResult);
            groupBoxResult.Location = new Point(555, 274);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(214, 105);
            groupBoxResult.TabIndex = 4;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод данных";
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = Color.White;
            textBoxResult.Location = new Point(16, 57);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(179, 23);
            textBoxResult.TabIndex = 2;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(16, 39);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(63, 15);
            labelResult.TabIndex = 2;
            labelResult.Text = "Результат:";
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(660, 393);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(109, 38);
            buttonDone.TabIndex = 5;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonHelp.Location = new Point(607, 393);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(38, 38);
            buttonHelp.TabIndex = 6;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxResult);
            Controls.Add(pictureBox1);
            Controls.Add(groupBoxTask);
            Controls.Add(groupBoxInputData);
            Name = "Form1";
            Text = "Sprint6 | Task0 | V14 | MarakovAD";
            Load += Form1_Load;
            groupBoxInputData.ResumeLayout(false);
            groupBoxInputData.PerformLayout();
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private GroupBox groupBoxInputData;
        private Label labelIntX;
        private TextBox textBoxIntX;
        private GroupBox groupBoxTask;
        private Label labelTask;
        private PictureBox pictureBox1;
        private GroupBox groupBoxResult;
        private TextBox textBoxResult;
        private Label labelResult;
        private Button buttonDone;
        private Button buttonHelp;
    }
}
