using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fort_coffee
{
    class order_rec
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-IEC3BN4Q;Initial Catalog=Fort_coffee;Integrated Security=True");
        SqlCommand cmd;
        SqlCommandBuilder builder;
        SqlDataAdapter adapter;
        DataSet ds; 
        public int add_item_order(string table_num, string item, int cost)
        {

            conn.Open();
            string str1 = "insert into orders values('" + table_num + "','" +item + "','" + cost + "')";
            SqlCommand cmd2 = new SqlCommand(str1, conn);
            //      conn.Open();
            int flag = cmd2.ExecuteNonQuery();
            // conn.Close();




            // int no = cmd.ExecuteNonQuery();


            return flag;
        }
    }
}
