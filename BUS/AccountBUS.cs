using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data.SqlClient;
using DTO;
namespace BUS
{
    public class AccountBUS
    {
        public List<Account> GetAccount()
        {
            try
            {
                return new AccountDAO().GetAccount();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public void AddNewAccount(string UserName, string Password, string DisplayName)
        {
            try
            {
                if (GetAccount().Where(a => a.UserName == UserName).FirstOrDefault() != null)
                {
                    throw new Exception("Tên tài khoản đã tồn tại !!!");
                }
                new AccountDAO().AddNewAccount(GetNextIDForAccount(), UserName, Password, DisplayName, 0, 0, DateTime.Today.AddDays(-1));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public string GetNextIDForAccount()// lấy mã nhân viên mới ra
        {
            try
            {
                string kq = "";
                if (GetAccount().OrderByDescending(p => p.Id).ToList().FirstOrDefault() == null)
                    kq = "NV1";
                else
                {
                    List<Account> list = GetAccount().OrderByDescending(p => p.Id).ToList();
                    int count = Convert.ToInt32(list.First().Id.Replace("NV", "")) + 1;
                    kq = "NV" + count;
                }
                return kq;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public void UpdateInfo(string userName, string password, string displayName)
        {
            try
            {
                new AccountDAO().UpdateInfo(userName, password, displayName);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void DeleteAccount(string userName)
        {
            try
            {
                new AccountDAO().DeleteAccount(userName);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
