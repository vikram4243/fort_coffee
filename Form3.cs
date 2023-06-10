using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fort_coffee
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            database_con db_con = new database_con();
            int num = db_con.add_data(name.Text, mobile.Text, user_id.Text, password.Text);
            if (num == 5) { label2.Text = "user already exists"; }
            else if (num > 0 && num < 5) { MessageBox.Show("record successfully added");
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else { label2.Text = "invalid opn"; }
        }

    }
}
