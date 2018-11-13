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
        public List<Account> GetAllAccount()
        {
            try
            {
                return new AccountDAO().GetAllAccount();
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
                if(GetAllAccount().Where(a => a.UserName == UserName).FirstOrDefault() != null)
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
                if (GetAllAccount().OrderByDescending(p => p.Id).ToList().FirstOrDefault() == null)
                    kq = "NV1";
                else
                {
                    List<Account> list = GetAllAccount().OrderByDescending(p => p.Id).ToList();
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

        public void UpdateCountDay(string userName, int totalDay)
        {
            try
            {
                Account a = GetAllAccount().Where(p => p.UserName == userName).FirstOrDefault();
                if (a == null)
                {
                    return;
                }
                else
                {
                    if (a.Yesterday == null || a.Yesterday != DateTime.Today.AddDays(-1))
                    {
                        new AccountDAO().UpdateYesterday(userName);
                        new AccountDAO().UpdateCountDay(userName, 1, totalDay);
                    }
                    else
                    {
                        new AccountDAO().UpdateCountDay(userName, a.CountDay + 1, a.TotalDay + totalDay);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public void UpdateCountMonth(string userName, int totalMonth)
        {
            try
            {
                Account a = GetAllAccount().Where(p => p.UserName == userName).FirstOrDefault();
                if (a == null)
                {
                    return;
                }
                else
                {
                    int countMonth = 0, total = 0;
                    if (a.Yesterday == null || a.Yesterday != DateTime.Today.AddDays(-1))
                    {
                        new AccountDAO().UpdateYesterday(userName);
                    }
                    if (a.Yesterday == (new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddDays(-1)))
                    {
                        countMonth = 1;
                        total = totalMonth;
                    }
                    else
                    {
                        countMonth = a.CountMonth + 1;
                        total = a.TotalMonth + totalMonth;
                    }
                    new AccountDAO().UpdateCountMonth(userName, countMonth, total);
                }
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
