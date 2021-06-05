using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class MenuService
    {
        static BankService bank = new();
        public static void LoadCashMenu()
        {
             
            int money = 0;
            int quantity = 0;
            Console.WriteLine("Available banknotes are shown below:");
            Console.WriteLine("1) 1 AZN\n2) 5 AZN\n3) 10 AZN\n4) 20 AZN\n5) 50 AZN\n6) 100 AZN\n7) 200 AZN");
            Console.WriteLine("Insert the banknote that you are going to add, please");
            string moneystr = Console.ReadLine();
            while (!int.TryParse(moneystr, out money))
            {
                Console.WriteLine("Insert the number, please");
                moneystr = Console.ReadLine();
            }
            Console.WriteLine("Enter the quantity, please");
            string quantitystr = Console.ReadLine();
            while (!int.TryParse(quantitystr, out quantity))
            {
                Console.WriteLine("Insert the number, please");
                quantitystr = Console.ReadLine();
            }
            try
            {
                bank.LoadCash(money, quantity);
            }
            catch (Exception e)
            {
                Console.WriteLine("An error has occured!");
                Console.WriteLine(e.Message);
            }
            
            int option = 0;
            do
            {
                Console.WriteLine("Do you want to add another banknote?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                Console.WriteLine("Select an option, please");
                string optionstr = Console.ReadLine();
                while (!int.TryParse(optionstr, out option))
                {
                    Console.WriteLine("Insert the number, please");
                    optionstr = Console.ReadLine();
                }
                switch (option)
                {
                    case 1:
                        int money1 = 0;
                        int quantity1 = 0;
                        Console.WriteLine("Available banknotes are shown below:");
                        Console.WriteLine("1) 1 AZN\n2) 5 AZN\n3) 10 AZN\n4) 20 AZN\n5) 50 AZN\n6) 100 AZN\n7) 200 AZN");
                        Console.WriteLine("Insert the banknote that you are going to add, please");
                        string moneystr1 = Console.ReadLine();
                        while (!int.TryParse(moneystr1, out money1))
                        {
                            Console.WriteLine("Insert the number, please");
                            moneystr = Console.ReadLine();
                        }
                        Console.WriteLine("Enter the quantity, please");
                        string quantitystr1 = Console.ReadLine();
                        while (!int.TryParse(quantitystr1, out quantity1))
                        {
                            Console.WriteLine("Insert a number, please");
                            quantitystr1 = Console.ReadLine();
                        }
                        try
                        {
                            bank.LoadCash(money1, quantity1);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("An error has occured!");
                            Console.WriteLine(e.Message);
                        }                        
                        break;
                    case 2:
                        Console.WriteLine("Cash loaded.");
                        break;
                    default:
                        Console.WriteLine("There is no such option!");
                        break;
                }
            } while (option!=2);
        }
        public static void InsertTheOutputMenu()
        {
            int money = 0;
            Console.WriteLine("Insert the amount that you want to take out");
            string moneystr = Console.ReadLine();
            while (!int.TryParse(moneystr, out money))
            {
                Console.WriteLine("Enter the number, please");
                moneystr = Console.ReadLine();
            }
            try
            {
                bank.InsertTheOutput(money);
                Console.WriteLine("Operation has been completed successfully!");
            }
            catch (Exception e)
            {
                Console.WriteLine("An error has occured.");
                Console.WriteLine(e.Message);               
            }                       
        }
    }
}
