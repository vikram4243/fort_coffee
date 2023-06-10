namespace fort_coffee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uid = textBox1.Text;
            string pwd = textBox2.Text;
            if (uid == "vikram" && pwd == "123")
            {
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();

            }
            else
            {
                label1.Text = "incorrect id or password";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();


        }
    }
}