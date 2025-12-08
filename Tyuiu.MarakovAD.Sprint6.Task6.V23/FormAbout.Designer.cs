namespace Tyuiu.MarakovAD.Sprint6.Task6.V23
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelIfo = new Label();
            buttonOK = new Button();
            SuspendLayout();
            // 
            // labelIfo
            // 
            labelIfo.Font = new Font("Tempus Sans ITC", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelIfo.Location = new Point(36, 29);
            labelIfo.Name = "labelIfo";
            labelIfo.Size = new Size(734, 373);
            labelIfo.TabIndex = 0;
            labelIfo.Text = "Работу выполнил MarakovAD";
            // 
            // buttonOK
            // 
            buttonOK.BackColor = Color.Chartreuse;
            buttonOK.Font = new Font("Snap ITC", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonOK.Location = new Point(266, 203);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(236, 125);
            buttonOK.TabIndex = 1;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = false;
            buttonOK.Click += buttonOK_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonOK);
            Controls.Add(labelIfo);
            Name = "FormAbout";
            Text = "FormAbout";
            ResumeLayout(false);
        }

        #endregion

        private Label labelIfo;
        private Button buttonOK;
    }
}