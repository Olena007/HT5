using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Store
{
    internal class Furniture
    {
        string type;
        string color;
        string price;
        string amount;

        public string Name
        {
            get { return $"{type} {color} {price} {amount}"; }
        }

        public Furniture(string type, string color, string price, string amount)
        {
            this.type = type;
            this.color = color;
            this.price = price;
            this.amount = amount;
        }
    }
}
