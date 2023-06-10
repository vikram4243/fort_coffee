using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace fort_coffee
{
    public partial class Form2 : Form
    {

        public static string table_num;
        public static int num = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Burger.Hide();
            Add.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void Add_Click(object sender, EventArgs e)
        {
            label9.Text = "-";
            string[] string_1 = new string[10];
            if (Burger.CheckedItems.Count > 0)
            {

                label9.Text += "-" + Convert.ToString(Burger.GetItemText(Burger.SelectedItem));
            }

        }

        private void Burger_SelectedIndexChanged(object sender, EventArgs e)
        {
            Add.Show();

        }




        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            table_num = listBox1.GetItemText(listBox1.SelectedItem);
        }


        private void Degree_coffee_Click(object sender, EventArgs e)
        {
            order_rec ent = new order_rec();
            num = ent.add_item_order(table_num, "Degree_coffee", 35);
            if (num > 0)
            {
                label8.Text = "Degree coffee added";
                num = 0;
            }
            else { label8.Text = "Sorry,error occured"; }
        }

        private void Dark_Black_coffee_Click(object sender, EventArgs e)
        {
            order_rec ent = new order_rec();
            num = ent.add_item_order(table_num, "Dark_Black_coffee", 45);
            if (num > 0)
            {
                label8.Text = "Dark Black coffee added";
                num = 0;
            }
            else { label8.Text = "Sorry,error occured"; }
        }

        private void Irish_Crema_Click(object sender, EventArgs e)
        {
            order_rec ent = new order_rec();
            num = ent.add_item_order(table_num, "Irish_crema_coffee", 70);
            if (num > 0)
            {
                label8.Text = "Irish Crema coffee added";
                num = 0;
            }
            else { label8.Text = "Sorry,error occured"; }
        }

        private void Robusta_white_Click(object sender, EventArgs e)
        {
            order_rec ent = new order_rec();
            num = ent.add_item_order(table_num, "Robusta_white_coffee", 80);
            if (num > 0)
            {
                label8.Text = "Robusta white coffee added";
                num = 0;
            }
            else { label8.Text = "Sorry,error occured"; }
        }

        private void Arabica_white_Click(object sender, EventArgs e)
        {
            order_rec ent = new order_rec();
            num = ent.add_item_order(table_num, "Arabica_white_coffee", 70);
            if (num > 0)
            {
                label8.Text = "Arabica white coffee added";
                num = 0;
            }
            else { label8.Text = "Sorry,error occured"; }
        }

        private void Calculate_total_Click(object sender, EventArgs e)
        {
            calculate_total clk = new calculate_total();
            int total1 = clk.total(table_num);
            label8.Text = Convert.ToString(total1);
        }

        private void Fort_cold_brew_Click(object sender, EventArgs e)
        {
            order_rec ent = new order_rec();
            num = ent.add_item_order(table_num, "Fort_cold_brew", 70);
            if (num > 0)
            {
                label8.Text = "Cold Brew coffee added";
                num = 0;
            }
            else { label8.Text = "Sorry,error occured"; }
        }

        private void Irish_Ice_coffee_Click(object sender, EventArgs e)
        {
            order_rec ent = new order_rec();
            num = ent.add_item_order(table_num, "Irish_ice_cold", 80);
            if (num > 0)
            {
                label8.Text = "Irish ice coffee added";
                num = 0;
            }
            else { label8.Text = "Sorry,error occured"; }
        }

        private void Robusta_ice_Click(object sender, EventArgs e)
        {
            order_rec ent = new order_rec();
            num = ent.add_item_order(table_num, "Robusta_ice_cold", 90);
            if (num > 0)
            {
                label8.Text = "Robusta ice coffee added";
                num = 0;
            }
            else { label8.Text = "Sorry,error occured"; }
        }

        private void Arabica_Ice_Click(object sender, EventArgs e)
        {
            order_rec ent = new order_rec();
            num = ent.add_item_order(table_num, "Arabica_ice_cold", 90);
            if (num > 0)
            {
                label8.Text = "Arabica ice coffee added";
                num = 0;
            }
            else { label8.Text = "Sorry,error occured"; }
        }

        private void Coffee_Apple_Click(object sender, EventArgs e)
        {
            order_rec ent = new order_rec();
            num = ent.add_item_order(table_num, "Coffee_apple_shot", 30);
            if (num > 0)
            {
                label8.Text = "coffee apple shot added";
                num = 0;
            }
            else { label8.Text = "Sorry,error occured"; }
        }

        private void Coffee_Lemonade_Click(object sender, EventArgs e)
        {
            order_rec ent = new order_rec();
            num = ent.add_item_order(table_num, "Coffee_lemonade_shot", 25);
            if (num > 0)
            {
                label8.Text = "coffee lemonade shot added";
                num = 0;
            }
            else { label8.Text = "Sorry,error occured"; }
        }

        private void Fort_Affogato_Click(object sender, EventArgs e)
        {
            order_rec ent = new order_rec();
            num = ent.add_item_order(table_num, "Fort Affogato", 60);
            if (num > 0)
            {
                label8.Text = "Fort Affogato added";
                num = 0;
            }
            else { label8.Text = "Sorry,error occured"; }
        }

        private void Coffee_ice_cream_Click(object sender, EventArgs e)
        {
            order_rec ent = new order_rec();
            num = ent.add_item_order(table_num, "Coffee_ice_cream", 65);
            if (num > 0)
            {
                label8.Text = "Coffee_ice_cream added";
                num = 0;
            }
            else { label8.Text = "Sorry,error occured"; }
        }

        private void Espresso_volcano_Click(object sender, EventArgs e)
        {
            order_rec ent = new order_rec();
            num = ent.add_item_order(table_num, "Espresso_volcano", 50);
            if (num > 0)
            {
                label8.Text = "Espresso_volcano added";
                num = 0;
            }
            else { label8.Text = "Sorry,error occured"; }
        }

        private void Cold_Stimulant_Click(object sender, EventArgs e)
        {
            order_rec ent = new order_rec();
            num = ent.add_item_order(table_num, "Cold_Stimulant", 60);
            if (num > 0)
            {
                label8.Text = "Cold Stimulant added";
                num = 0;
            }
            else { label8.Text = "Sorry,error occured"; }
        }

        private void Coffee_Insomniac_Click(object sender, EventArgs e)
        {
            order_rec ent = new order_rec();
            num = ent.add_item_order(table_num, "Coffee_Insomniac", 55);
            if (num > 0)
            {
                label8.Text = "Coffee Insomniac added";
                num = 0;
            }
            else { label8.Text = "Sorry,error occured"; }
        }

        private void Fusion_burger_Click(object sender, EventArgs e)
        {
            Burger.Show();
            order_rec ent = new order_rec();
            num = ent.add_item_order(table_num, "Fusion burger", 70);
            if (num > 0)
            {
                label8.Text = "fusion burger added";
                num = 0;
            }
            else { label8.Text = "Sorry,error occured"; }

        }

        private void button23_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }
    }
}
