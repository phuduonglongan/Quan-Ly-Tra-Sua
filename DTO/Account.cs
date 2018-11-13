using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string DisplayName { get; set; }
        public int CountDay { get; set; }
        public int CountMonth { get; set; }
        public DateTime Yesterday { get; set; }
        public int TotalDay { get; set; }
        public int TotalMonth { get; set; }

        public Account()
        {
            this.Id = this.UserName = this.PassWord = null;
            this.CountDay = this.CountMonth = this.TotalDay = this.TotalMonth = 0;
            this.Yesterday = DateTime.Today.AddDays(-1);
        }

        public Account(string id, string username, string password, string displayname, int countday, int countmonth, DateTime yesterday, int totalDay, int totalMonth)
        {
            this.Id = id;
            this.UserName = username;
            this.PassWord = password;
            this.DisplayName = displayname;
            this.CountDay =countday;
            this.CountMonth = countmonth;
            this.Yesterday = yesterday;
            this.TotalMonth = totalMonth;
            this.TotalDay = totalDay;
        }
    }
}
