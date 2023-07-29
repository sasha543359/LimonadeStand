using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Game.Day
{
    internal class Day
    {
        public Weather weather { get; set; }
        public List<Customer> customers = new List<Customer>();

        public Day(Weather weather)
        {
            this.weather = weather;

            int cutomersNumber = new Random().Next(5, 30);

            for (int i = 1; i <= cutomersNumber; i++)
            {
                customers.Add(new Customer());
            }
        }
    }
}
