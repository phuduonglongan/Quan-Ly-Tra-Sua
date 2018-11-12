using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
   public class AccountDAO: DataProvider
    {
        public List<Account> GetAccount()
        {
            string sql = "SELECT * FROM Account";
            connect();
            try
            {
                SqlDataReader dr = ExecuteReader(sql);
                string id, username, password, displayname;
                int countday, countmonth, totalDay, totalMonth;
                DateTime yesterday;
                List<Account> list = new List<Account>();
                while (dr.Read())
                {
                    id = dr[0].ToString();
                    username = dr[1].ToString();
                    password = dr[2].ToString();
                    displayname = dr[3].ToString();
                    countday = Convert.ToInt16(dr[4]);
                    countmonth = Convert.ToInt16(dr[5]);
                    yesterday = dr[6] != DBNull.Value ? Convert.ToDateTime(dr[6]) : DateTime.Today.AddDays(-1);
                    totalDay = Convert.ToInt32(dr[7]);
                    totalMonth = Convert.ToInt32(dr[8]);
                    Account account = new Account(id, username, password, displayname, countday, countmonth, yesterday, totalDay, totalMonth);
                    list.Add(account);
                }
                dr.Close();
                return list;
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
        public void AddNewAccount(string ID, string UserName, string Password, string DisplayName, int CountDay, int CountMonth, DateTime yesterday)
        {
            connect();
            string sql = "INSERT INTO Account(id, UserName, PassWord, DisplayName, CountDay, CountMonth, Yesterday) VALUES ('" + ID + "', '" + UserName + "', '" + Password + "', N'" + DisplayName + "', " + CountDay + "," + CountMonth + ", '" + yesterday.ToString() + "')";
            try
            {
                RunSQL(sql);
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
    }
}

