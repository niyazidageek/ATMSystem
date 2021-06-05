using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Bank
    {
        public List<int> Base { get; set; }
        public Bank()
        {
            Base = new() { 1, 5, 10, 20, 50, 100, 200 };
        }
    }
}
