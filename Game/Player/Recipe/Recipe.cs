using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Game.Player.Recipe
{
    public class Recipe
    {
        public int amountOfLemons { get; set; }
        public int amountOfSugarCubes { get; set; }
        public int amountOfIceCubes { get; set; }
        public double pricePerCup { get; set; }

        public Recipe(int lemonsAmount, int sugarCubesAmount, int iceCubesAmount, double pricePerCup)
        {
            this.pricePerCup = pricePerCup;
            amountOfLemons = lemonsAmount;
            amountOfSugarCubes = sugarCubesAmount;
            amountOfIceCubes = iceCubesAmount;

        }
    }
}
