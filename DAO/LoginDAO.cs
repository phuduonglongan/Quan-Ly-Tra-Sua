using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    public class LoginDAO : DataProvider
    {
        public bool login(string user, string pass)
        {
            string sql = "SELECT COUNT(UserName) FROM Account WHERE UserName = '" + user + "' AND PassWord = '" + pass + "'";
            int number;
            try
            {
                number = myExecuteScalar(sql);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            if (number > 0)
                return true;
            else
                return false;
        }

    }
}

