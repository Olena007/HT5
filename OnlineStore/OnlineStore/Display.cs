using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    internal class Display
    {
        public void Entrance()
        {
            Console.WriteLine("Availiability of the furniture: ");
            Console.WriteLine("Type:     Color:     Price:        ");
        }

        public void WriteArray(string[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        public void WriteLineConsole()
        {
            Console.WriteLine("Write furtiture (for instance: sofa blue 400):");
        }

        public void WriteCash()
        {
            Console.WriteLine("Write the amount of the purchase:");
        }

        public void Order()
        {
            Console.WriteLine("Do you want to place the order ?");
        }
        public void MessageMoney()
        {
            Console.WriteLine("Ooops, it appears your account has insufficienr funds.");
        }

    }
}
