namespace HelloApp
{
    partial class Form4
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            richTextBox1 = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.SaddleBrown;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(22, 12);
            button1.Name = "button1";
            button1.Size = new Size(139, 46);
            button1.TabIndex = 0;
            button1.Text = "главная";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SaddleBrown;
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(185, 12);
            button2.Name = "button2";
            button2.Size = new Size(139, 46);
            button2.TabIndex = 1;
            button2.Text = "вернуться";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SaddleBrown;
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(359, 12);
            button3.Name = "button3";
            button3.Size = new Size(139, 46);
            button3.TabIndex = 2;
            button3.Text = "добавить";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(220, 128);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(228, 225);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(220, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 27);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private RichTextBox richTextBox1;
        private OpenFileDialog openFileDialog1;
        private TextBox textBox1;
    }
}