using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace fort_coffee
{
    class find_bill
    {
        SqlConnection conn1 = new SqlConnection("Data Source=LAPTOP-IEC3BN4Q;Initial Catalog=Fort_coffee;Integrated Security=True");
        SqlCommand cmd;
        SqlCommandBuilder builder;
        SqlDataAdapter adapter;
        DataSet ds;

            public int calctot(String tab_num_calc) {
            conn1.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from customers", conn1);
                return 0;
            }
        

    }
}
