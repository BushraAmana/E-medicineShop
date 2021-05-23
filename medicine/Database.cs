using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace medicine
{
    public class Database
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter adt;
        private DataTable dt;
        private DataSet ds;

        public void openConnection()
        {
            string connectionString = "Data Source=DESKTOP-LPEAS44\\BUSHRA;Initial Catalog=Medicine;Integrated Security=True";
            con = new SqlConnection(connectionString);
            con.Open();
        }
        public DataTable Table(string query)
        {
            try
            {
                this.openConnection();
                dt = new DataTable();
                ds = new DataSet();
                cmd = new SqlCommand(query, con);
                adt = new SqlDataAdapter(cmd);
                adt.Fill(ds);
                return ds.Tables[0];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return new DataTable();
        }
        public void update(string query)
        {
            try
            {
                this.openConnection();
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public bool checkSpecificRow(string query)
        {
            try
            {
                this.openConnection();
                dt = new DataTable();
                ds = new DataSet();
                cmd = new SqlCommand(query, con);
                adt = new SqlDataAdapter(cmd);
                adt.Fill(ds);
                dt = ds.Tables[0];
                if (dt.Rows.Count == 1)
                    return true;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                con.Close();
            }
            return false;
        }
    }
}
