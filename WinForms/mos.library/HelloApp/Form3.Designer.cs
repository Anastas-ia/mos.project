namespace HelloApp
{
    partial class Form3
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
            label1 = new Label();
            listBox1 = new ListBox();
            label2 = new Label();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Peru;
            label1.Location = new Point(22, 74);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "все книги";
            label1.Click += label1_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Peru;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(22, 111);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(139, 304);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Peru;
            label2.Location = new Point(249, 74);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "автор";
            label2.Click += label2_Click;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.Peru;
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(249, 111);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(139, 304);
            listBox2.TabIndex = 3;
            // 
            // listBox3
            // 
            listBox3.BackColor = Color.Peru;
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(463, 111);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(139, 304);
            listBox3.TabIndex = 4;
            listBox3.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Peru;
            label3.Location = new Point(463, 74);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 5;
            label3.Text = "название";
            // 
            // button1
            // 
            button1.BackColor = Color.SaddleBrown;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(22, 12);
            button1.Name = "button1";
            button1.Size = new Size(139, 46);
            button1.TabIndex = 6;
            button1.Text = "главная";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SaddleBrown;
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(619, 12);
            button2.Name = "button2";
            button2.Size = new Size(139, 46);
            button2.TabIndex = 7;
            button2.Text = "добавить файл";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private Label label2;
        private ListBox listBox2;
        private ListBox listBox3;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}