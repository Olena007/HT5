using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    internal class Order
    {
        Basket basket = new Basket();
        public void Finish(string answer)
        {
            if (answer == "yes")
            {
                Console.WriteLine("Order is processed!");
            }
            else if (answer == "no")
            {
                Console.WriteLine("Order is cancled. PRESS ENTER TO EXIT!");
            }
        }
    }
}
