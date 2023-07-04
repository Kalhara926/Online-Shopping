using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_shopping
{
    class DBFunction
    {
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=Windows-f07og7q;Initial Catalog=db_online_shopping;Integrated Security=True;Pooling=False";
            return con;
        }


        // Method for Data Read............
        public DataSet getData(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public object getDataScalar(string query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            object result = cmd.ExecuteScalar();
            con.Close();
            return result;
        }

        //Method for Data Insert..............
        public void setData(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Insert Data Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        //Method for Data Delete..................
        public void deleteData(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Delete Product Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //Method for Data Update................
        public void updateData(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Product Update successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public object getSingleValue(string query)
        {
            object result = null;
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                result = reader.GetValue(0);
            }
            reader.Close();
            con.Close();
            return result;
        }
    }
}
