using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Drinks
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Drinks(string id, string name, double price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }
    }
}
