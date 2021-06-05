using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            do
            {
                Console.WriteLine("1. Load cash");
                Console.WriteLine("2. Set the output");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Select the option, please");
                string optionstr = Console.ReadLine();
                while(!int.TryParse(optionstr, out option))
                {
                    Console.WriteLine("Insert the number, please!");
                    optionstr = Console.ReadLine();
                }
                switch (option)
                {
                    case 1:
                        MenuService.LoadCashMenu();
                        break;
                    case 2:
                        MenuService.InsertTheOutputMenu();                       
                        break;
                    case 0:
                        Console.WriteLine("Shutting down!");
                        break;
                    default:
                        Console.WriteLine("There is no such option!");
                        break;
                }
            } while (option != 0);
        }
    }
}
