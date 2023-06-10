using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace fort_coffee
{
    class calculate_total
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-IEC3BN4Q;Initial Catalog=Fort_coffee;Integrated Security=True");
        SqlCommand cmd;
        SqlCommandBuilder builder;
        SqlDataAdapter adapter;
        DataSet ds;
        public int total(string table_num)
        {

            string str = "select SUM(cost) from orders where table_num=@table_num";
            //select SUM(cost) from orders where table_num='Table_No_4'
            conn.Open();
            cmd = new SqlCommand(str, conn);
            cmd.Parameters.AddWithValue("table_num", table_num);
            SqlDataReader reader1;
            //reader1 = cmd.ExecuteReader();
            //string flag = Convert.ToString(reader1);
          //  int err = Convert.ToInt32(reader1.Read());
         string flag= cmd.ExecuteScalar().ToString();
          //  reader1.Close();
          int err = Convert.ToInt32(flag);
            conn.Close();
            return err;
        }
    }
}
