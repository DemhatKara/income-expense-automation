using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Otomasyon.Cls
{
    public class SQLConnectionClass
    {
        private string SQLConnectionString = "Data Source=YUKSEL\\SQLEXPRESS;Initial Catalog=otomasyon;Integrated Security=True";
        private SqlConnection con = new SqlConnection();
        private SqlDataAdapter da = new SqlDataAdapter();
        private SqlCommand com = new SqlCommand();
        public SqlException exception = null;

        public void Baglanti()
        {
            exception = null;
            con = new SqlConnection(SQLConnectionString);
            if (con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                }
                catch (SqlException ex)
                {

                    MessageBox.Show(ex.GetType().Name + " - " + ex.Message);
                }
            }
        }

        public object Command(string query)
        {
            exception = null;
            object obj = null;
            com.Connection = con; // SqlCommand
            com.CommandText = query; 

            try
            {
                obj = com.ExecuteScalar();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.GetType().Name + " - " + ex.Message);
            }

            return obj;
        }

        public DataTable Table(string query)
        {
            DataTable dt = new DataTable();
            com.Connection = con; 
            com.CommandText = query; // SqlCommand
            da.SelectCommand = com; // // SqlCommand'ın bir select sorgusu olduğunu belirtiyoruz.
            try
            {
                da.Fill(dt);
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.GetType().Name + " - " + ex.Message);
            }
            return dt;
        }

        internal object Table(object value)
        {
            throw new NotImplementedException();
        }
    }
}