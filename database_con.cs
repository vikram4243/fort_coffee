using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace fort_coffee
{
    class database_con
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-IEC3BN4Q;Initial Catalog=Fort_coffee;Integrated Security=True");
        SqlCommand cmd;
        SqlCommandBuilder builder;
        SqlDataAdapter adapter;
        DataSet ds;
        public int add_data(string name,string mobile_no,string username,string password)
        {
            string str = "select name_reg,mob_num,username from users where username=@username";
            conn.Open();
            cmd = new SqlCommand(str, conn);
            cmd.Parameters.AddWithValue("username", username);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            int flag = 0;

            if (reader1.Read()) {
                if (reader1["username"].ToString()==username) {
                    reader1.Close();
                    //flag = 5;

                    return 5;
                }
                reader1.Close();
            }
            reader1.Close();
            conn.Close();
            conn.Open();
            string str1 = "insert into users values('" + name + "','" + mobile_no + "','" + username + "','" + password + "')";
                SqlCommand cmd2 = new SqlCommand(str1, conn);
          //      conn.Open();
                flag = cmd2.ExecuteNonQuery();
                // conn.Close();


            

            // int no = cmd.ExecuteNonQuery();


            return flag;
        }
    }
}
