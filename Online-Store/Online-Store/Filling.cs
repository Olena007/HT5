using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Store
{
    internal class Filling
    {
        public string[] arr = new string[4];
        Furniture sofa = new("Sofa", "white", "300", "1");
        Furniture chair = new("Chair", "white", "100", "3");
        Furniture bed = new("Bed", "black", "500", "2");
        Furniture table = new("Table", "white", "200", "4");

        public void Fill()
        {
            for (int i = 0; i < this.arr.Length; i++)
            {
                if (i == 0)
                {
                    this.arr[i] = this.sofa.ToString();
                }
                else if (i == 1)
                {
                    this.arr[i] = this.chair.ToString();
                }
                else if (i == 2)
                {
                    this.arr[i] = this.bed.ToString();
                }
                else if (i == 3)
                {
                    this.arr[i] = this.table.ToString();
                }
            }
        }

        public string GoThrought()
        {
            foreach (string i in this.arr)
            {
                return i;
            }
        }
    }
}
