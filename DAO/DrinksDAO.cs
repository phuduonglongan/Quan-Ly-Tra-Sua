using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class DrinksDAO:DataProvider
    {
        public List<Drinks> GetDrinks_Topping(string type)
        { 
            string sql = "SELECT * FROM DrinkToppingName WHERE Id LIKE '" + type +"%'";
            connect();
            try
            {
                SqlDataReader dr = ExecuteReader(sql);
                string id, name;
                double price;
                List<Drinks> list = new List<Drinks>();
                while (dr.Read())
                {
                    id = dr[0].ToString();
                    name = dr[1].ToString();
                    price = Convert.ToDouble(dr[2]);
                    Drinks drink = new Drinks(id, name, price);
                    list.Add(drink);
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
    }
}
