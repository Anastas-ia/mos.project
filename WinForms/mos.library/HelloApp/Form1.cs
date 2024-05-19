using Microsoft.VisualBasic.ApplicationServices;

namespace HelloApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button1.Click += button1_Click;
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show(); ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(this);
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
