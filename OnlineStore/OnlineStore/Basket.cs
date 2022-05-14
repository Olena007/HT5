using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    internal class Basket
    {
        Display display = new Display();
        public string[,] Add(string[] arr, int cash, string request)
        {
            string[,] arr2 = new string[arr.Length,3];
            string[] req = request.Split(',');
            int k = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                string line = "";
                if (k < req.Length)
                {
                    line = req[k];

                    string[] str = line.Split(' ');

                    if (cash > Convert.ToInt32(str[2]))
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (arr[i] != null && str[j] != null)
                            {
                                if (cash > Convert.ToInt32(str[2]))
                                {
                                    if (arr.Contains(req[k]))
                                    {
                                        if (arr2[i, j] == null)
                                        {
                                            arr2[i, j] = str[j];
                                            Console.Write(arr2[i, j] + " " );
                                        }
                                    }

                                }

                            }
                        }
                    }
                    else
                    {
                        display.MessageMoney();
                    }
                    
                    k++;
                    cash = cash - Convert.ToInt32(str[2]);
                }
            }
            return arr2;
        }
    }
}
