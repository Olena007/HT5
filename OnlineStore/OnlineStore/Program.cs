using System;

namespace OnlineStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Furniture sofa = new Furniture("Sofa", "red", 300);
            Furniture chair = new Furniture("Chair", "yellow", 100);
            Furniture bed = new Furniture("Bed", "white", 200);
            Furniture table = new Furniture("Table", "braun", 400);
            Furniture armchair = new Furniture("Armchair", "black", 300);
            Furniture wardrobe = new Furniture("Wardrobe", "braun", 600);
            Furniture bookcase = new Furniture("Bookcase", "yellow", 200);
            Furniture rug = new Furniture("Rug", "red", 50);
            Furniture curtains = new Furniture("Curtains", "pink", 70);
            Furniture clock = new Furniture("Clock", "white", 30);

            Display display = new Display();
            display.Entrance();
            string[] arr = new string[10];

            Filling filling = new Filling();
            filling.Assignment(sofa, arr);
            filling.Assignment(chair, arr);
            filling.Assignment(bed, arr);
            filling.Assignment(table, arr);
            filling.Assignment(armchair, arr);
            filling.Assignment(wardrobe, arr);
            filling.Assignment(bookcase, arr);
            filling.Assignment(rug, arr);
            filling.Assignment(curtains, arr);
            filling.Assignment(clock, arr);
            
            display.WriteArray(arr);

            Basket basket = new Basket();

            display.WriteLineConsole();
            string line = Console.ReadLine();

            display.WriteCash();
            int cash = Convert.ToInt32(Console.ReadLine());

            basket.Add(arr, cash, line);

            display.Order();
            string answer = Console.ReadLine();
            Order order = new Order();
            order.Finish(answer);
            Console.ReadKey();
        }
    }
}
