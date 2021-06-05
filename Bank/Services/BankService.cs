using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class BankService:Bank
    {     
        public List<int> Output { get; set; }
        public BankService():base()
        {           
            Output = new();
        }
        
        public void LoadCash(int money, int quantiy)
        {
            if ((money <= 0)|| (money != 1 && money !=5 && money != 10 && money !=20 && money != 50 && money != 100 && money != 200))
                throw new KeyNotFoundException("Wrong banknote input type!");
            if (quantiy <= 0)
                throw new ArgumentOutOfRangeException("The given quantity is wrong! Make sure that the quantity is more than 0!");
            for (int i = 0; i < quantiy; i++)
            {
                Base.Add(money);
            }           
        }
        public void InsertTheOutput(int money)
        {   
            while (money/200 >=1 && Base.Contains(200))
            {
                Base.Remove(200);
                money -= 200;
                Output.Add(200);
            }
            while (money / 100 >= 1 && Base.Contains(100))
            {
                Base.Remove(100);
                money -= 100;
                Output.Add(100);
            }
            while (money / 50 >= 1 && Base.Contains(50))
            {
                Base.Remove(50);
                money -= 50;
                Output.Add(50);
            }
            while (money / 20 >= 1 && Base.Contains(20))
            {
                Base.Remove(20);
                money -= 20;
                Output.Add(20);
            }
            while (money / 10 >= 1 && Base.Contains(10))
            {
                Base.Remove(10);
                money -= 10;
                Output.Add(10);
            }
            while (money / 5 >= 1 && Base.Contains(5))
            {
                Base.Remove(5);
                money -= 5;
                Output.Add(5);
            }
            var manats = Base.FindAll(s => s == 1);            
            while (manats.Count>=money&&money!=0)
            {
                Base.Remove(1);
                money -= 1;
                Output.Add(1);
            }
            if (money != 0)
            {
                foreach (var item in Output.ToList())
                {
                    if (Output.ToList().Count >= 1)
                    {
                        Base.Add(item);
                        Output.Remove(item);
                    }                   
                }
                throw new KeyNotFoundException("There is not enough cash in ATM");
            }           
            var result = from x in Output group x by x into y select y;
            foreach (var item in result)
            {
                Console.WriteLine($"Banknote: {item.Key} | Quantity: {item.Count()}");
            }
            Output.Clear();
        }
    }
}
