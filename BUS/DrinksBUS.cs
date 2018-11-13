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
    public class DrinksBUS
    {
        public List<Drinks> GetDrinks_Topping(string type)
        {
            try
            {
                return new DrinksDAO().GetDrinks_Topping(type);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
