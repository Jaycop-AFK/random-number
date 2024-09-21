namespace random_number
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
            button1 = new Button();
            lashow = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(328, 90);
            button1.Name = "button1";
            button1.Size = new Size(140, 38);
            button1.TabIndex = 0;
            button1.Text = "ทายตัวเลข";
            button1.UseVisualStyleBackColor = true;
            // 
            // lashow
            // 
            lashow.AutoSize = true;
            lashow.Location = new Point(379, 342);
            lashow.Name = "lashow";
            lashow.Size = new Size(34, 15);
            lashow.TabIndex = 1;
            lashow.Text = ".........";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(333, 193);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(135, 80);
            textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.random_numbers;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(lashow);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lashow;
        private TextBox textBox1;
    }
}
