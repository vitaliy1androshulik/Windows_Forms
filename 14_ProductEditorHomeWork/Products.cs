using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_ProductEditorHomeWork
{
    public class Products
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public string Country { get; set; }
        public int Discount { get; set; }

        public Products() : this("noname", 0, 0, "no", 0) { }
        public Products(string name, int price, int count, string country, int discount)
        {
            this.Name = name;
            this.Price = price;
            this.Count = count;
            this.Country = country;
            this.Discount = discount;
        }

        public override string ToString()
        {
            return $"{Name}, count - {Count}";
        }
    }
}
