using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    internal class Furniture
    {
        public string Type { get; set; }

        public string Color { get; set; }

        public float Price { get; set; }

        public Furniture(string type, string color, float price)
        {
            Type = type;
            Color = color;
            Price = price;
        }
    }
}
