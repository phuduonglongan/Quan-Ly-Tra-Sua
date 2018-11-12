using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using DAO;

namespace BUS
{
    public class DrinkBUS
    {
        public List<Drinks> GetDrinks_Topping(string type)
        {
            try
            {
                return new DrinkDAO().GetDrinks_Topping(type);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
