using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Game.Day
{
    public enum Conditions
    {
        Sunny = 0,
        Rain = 1,
        Cloudy = 2,
    }
    public class Weather
    {
        public int Temperature { get; set; }

        List<Conditions> weatherConditions = new List<Conditions>();

        public string Condition { get; set; }

        public Weather()
        {
            Temperature = new Random().Next(10, 45);

            Condition = Temperature >= 10 && Temperature <= 20
                ? Conditions.Rain.ToString() : Temperature > 20 && Temperature <= 25
                ? Conditions.Cloudy.ToString() : Temperature > 25 && Temperature <= 45
                ? Conditions.Sunny.ToString() : Conditions.Sunny.ToString();
        }
    }
}
