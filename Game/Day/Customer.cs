using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Game.Day
{
    internal class Customer
    {
        public double Balance { get; set; }

        public Customer()
        {
            Balance = (new Random().Next(0, 30));
            Balance /= 100;
        }
    }
}
