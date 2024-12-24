namespace Tyuiu.NedelkinFA.Sprint6.Task1.V10
{
    partial class FormMain
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
            textBoxResult = new TextBox();
            buttonVipolnit = new Button();
            buttonSpravka = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(16, 26);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(234, 27);
            textBoxResult.TabIndex = 0;
            textBoxResult.Text = "укенгш";
            textBoxResult.TextChanged += textBox1_TextChanged;
            // 
            // buttonVipolnit
            // 
            buttonVipolnit.BackColor = SystemColors.ActiveCaption;
            buttonVipolnit.Location = new Point(497, 368);
            buttonVipolnit.Name = "buttonVipolnit";
            buttonVipolnit.Size = new Size(94, 29);
            buttonVipolnit.TabIndex = 1;
            buttonVipolnit.Text = "выполнить";
            buttonVipolnit.UseVisualStyleBackColor = false;
            // 
            // buttonSpravka
            // 
            buttonSpravka.BackColor = SystemColors.Info;
            buttonSpravka.Location = new Point(387, 368);
            buttonSpravka.Name = "buttonSpravka";
            buttonSpravka.Size = new Size(94, 29);
            buttonSpravka.TabIndex = 2;
            buttonSpravka.Text = "справка";
            buttonSpravka.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxResult);
            groupBox1.Location = new Point(16, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(575, 125);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(buttonSpravka);
            Controls.Add(buttonVipolnit);
            Name = "FormMain";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxResult;
        private Button buttonVipolnit;
        private Button buttonSpravka;
        private GroupBox groupBox1;
    }
}
