using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_ComboBox
{
    internal class Order
    {
        public static int count = 1000;
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }
        public Order():this(0) { }
        public Order(decimal price)
        {
            Number = count++;
            Date = DateTime.Now;
            TotalPrice = price;
        }
        
        public override string ToString()
        {
            return $"№{Number}  {Date.ToLongDateString()}  {TotalPrice}$";
        }
    }
}
