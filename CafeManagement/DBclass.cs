using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Class for connecting database with the program

namespace CafeManagement
{
    class DBclass
    {
        protected SqlConnection getConnection()
        {
            SqlConnection connect = new SqlConnection();
            //Uncomment the line below and insert your SQL server name and your database in my case the database is "cafe"
            //connect.ConnectionString = "data source = ; database = cafe; integrated security = True";
            return connect;
        }
        
        public DataSet getData(String query)
        {
            SqlConnection connect = getConnection();
            SqlCommand SQLcmd = new SqlCommand();
            SQLcmd.Connection = connect;
            SQLcmd.CommandText = query;
            SqlDataAdapter SQLda = new SqlDataAdapter(SQLcmd);
            DataSet SQLds = new DataSet();
            SQLda.Fill(SQLds);
            return SQLds;
        }

        public void setData(String query)
        {
            SqlConnection connect = getConnection();
            SqlCommand SQLcmd = new SqlCommand();
            SQLcmd.Connection = connect;
            connect.Open();
            SQLcmd.CommandText = query;
            SQLcmd.ExecuteNonQuery();
            connect.Close();
        }

    }
}
