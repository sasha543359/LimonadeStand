using ConsoleApp1.Game.Player.Invent.Ingredietns;

namespace ConsoleApp1.Game.Player.Inventory
{
    public class Inventory
    {
        public List<Lemon> lemons = Enumerable.Repeat<Lemon>(new Lemon(), 15).ToList();
        public List<SugarCube> sugarCubes = Enumerable.Repeat<SugarCube>(new SugarCube(), 15).ToList();
        public List<IceCube> iceCubes = Enumerable.Repeat<IceCube>(new IceCube(), 15).ToList();
        public List<Cup> cups = Enumerable.Repeat<Cup>(new Cup(), 15).ToList();

        public void ShowInventory()
        {
            Console.WriteLine($"You have \n" +
                $"{lemons.Count} lemons \n" +
                $"{sugarCubes.Count} sugar cubes\n" +
                $"{iceCubes.Count} ice cubes \n" +
                $"{cups.Count} cups");
        }

    }
}
