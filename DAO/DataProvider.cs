using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAO
{
    public class DataProvider
    {
        SqlConnection cn;
        public DataProvider()
        {
            string cnstr = "Server= . ; Database = QuanLiQuanTraSua1; Integrated Security = true;";
            cn = new SqlConnection(cnstr);
        }
        public void connect()
        {
            try
            {
                if (cn != null && cn.State == System.Data.ConnectionState.Closed)
                {
                    cn.Open();
                }
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public void disconnect()
        {
            try
            {

                if (cn != null && cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public int myExecuteScalar(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Connection = cn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            connect();
            try
            {
                int number = (int)cmd.ExecuteScalar();
                return number;

            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                disconnect();
            }
        }
        public SqlDataReader ExecuteReader(string sql) //dùng để đọc dữ liệu từ câu truy vấn
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn);
                return cmd.ExecuteReader();
            }
            catch (InvalidCastException ex)
            {
                throw ex;
            }
            catch (InvalidOperationException ex)
            {
                throw ex;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public void RunSQL(string sql)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.ExecuteNonQuery();
            }
            catch (InvalidCastException ex)
            {
                throw ex;
            }
            catch (InvalidOperationException ex)
            {
                throw ex;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }//end of Add
    }
}
