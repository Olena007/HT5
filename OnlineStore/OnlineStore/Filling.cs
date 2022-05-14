using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    internal class Filling
    {
        public void Assignment(Furniture furniture, string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                string type = furniture.Type.ToString();
                string color = furniture.Color.ToString();
                float price = furniture.Price;

                if (arr[i] == null)
                {
                    arr[i] = $"{type} {color} {price}";
                    break;
                }
            }
        }
    }
}
