using ConsoleApp1.Game.Day;
using ConsoleApp1.Game.Player;
using ConsoleApp1.Game.Player.Invent.Ingredietns;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security;
using System.Text.Json;

namespace ConsoleApp1.Game
{
    internal class Game
    {
        Player.Player player { get; set; }

        List<Day.Day> days = new List<Day.Day>();

        Store.Store store { get; set; } = new Store.Store();

        public int currentDay { get; set; } = 1;

        public Game()
        {
            CreatePlayer();
            Registartion();
            Menu();
        }

        public void Registartion()
        {
            Console.WriteLine($"Hi {player.name} choose how many days you want to play");

            Console.WriteLine(
               "1. 7 days\n" +
               "2. 14 days\n" +
               "3. 30 days\n");

            int value = int.Parse(Console.ReadLine());

            while (value != 1 && value != 2 && value != 3)
            {


                Console.WriteLine("Choose one of this variants");

                Console.WriteLine(
                     "1. 7 days\n" +
                     "2. 14 days\n" +
                     "3. 30 days\n");

                value = int.Parse(Console.ReadLine());

                Console.Clear();
            }

            int daysNumber = 0;

            switch (value)
            {
                case 1: daysNumber = 7; break;
                case 2: daysNumber = 14; break;
                case 3: daysNumber = 30; break;

            }
            for (int i = 0; i < daysNumber; i++)
            {
                days.Add(new Day.Day(new Weather()));
            }
        }
        public void CreatePlayer()
        {
            Console.WriteLine("Hi, what is your name ?");
            string name = Console.ReadLine();
            player = new Player.Player(name, new Player.Inventory.Inventory(), new Player.Wallet.Wallet(), new Player.Recipe.Recipe(1, 1, 1, 0.25));
        }
        public void Menu()
        {
            Console.Clear();

            Console.WriteLine($"Name: {player.name} | Money: {player.wallet.Money}$ | CurrentDay: {currentDay}");

            Console.WriteLine(
                $"1. Play\n" +
                $"2. Shop\n" +
                $"3. Lemonade Price\n");

            int value = int.Parse(Console.ReadLine());

            while (value != 1 && value != 2 && value != 3)
            {
                Console.WriteLine("Chose one of this variants");
                value = int.Parse(Console.ReadLine());

            }

            switch (value)
            {
                case 1:
                    Console.Clear();
                    Play();
                    break;
                case 2:
                    Console.Clear();
                    Shop();
                    break;
                case 3:
                    Recipe();
                    break;
            }

        }
        public void Recipe()
        {
            Console.Clear();
            Console.WriteLine($"1. Change price per cup | Current price per cup {player.recipe.pricePerCup} cents\n" +
                $"2. Change amount lemoms per cup | Current amount per cup is {player.recipe.amountOfLemons} \n" +
                $"3. Change amount cube sugar per cup | Current amount per cup is {player.recipe.amountOfSugarCubes} \n" +
                $"4. Change amount ice cubes per cup | Current amount per cup is {player.recipe.amountOfIceCubes} \n" +
                $"5. Exit \n");

            int value = int.Parse(Console.ReadLine());

            while (value != 1 && value != 2 && value != 3 && value != 4 && value != 5)
            {
                Console.WriteLine("Chose one of this variants");
                value = int.Parse(Console.ReadLine());

            }

            while (true)
            {
                switch (value)
                {
                    case 1:
                        Console.WriteLine("Write new price: ");
                        player.recipe.pricePerCup = double.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine($"1. Change price per cup | Current price per cup {player.recipe.pricePerCup} cents\n" +
                            $"2. Change amount lemoms per cup | Current amount per cup is {player.recipe.amountOfLemons} \n" +
                            $"3. Change amount cube sugar per cup | Current amount per cup is {player.recipe.amountOfSugarCubes} \n" +
                            $"4. Change amount ice cubes per cup | Current amount per cup is {player.recipe.amountOfIceCubes} \n" +
                            $"5. Exit \n");
                        break;
                    case 2:
                        Console.WriteLine("Write new price: ");
                        player.recipe.amountOfLemons = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine($"1. Change price per cup | Current price per cup {player.recipe.pricePerCup} cents\n" +
                            $"2. Change amount lemoms per cup | Current amount per cup is {player.recipe.amountOfLemons} \n" +
                            $"3. Change amount cube sugar per cup | Current amount per cup is {player.recipe.amountOfSugarCubes} \n" +
                            $"4. Change amount ice cubes per cup | Current amount per cup is {player.recipe.amountOfIceCubes} \n" +
                            $"5. Exit \n");
                        break;
                    case 3:
                        Console.WriteLine("Write new price: ");
                        player.recipe.amountOfSugarCubes = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine($"1. Change price per cup | Current price per cup {player.recipe.pricePerCup} cents\n" +
                            $"2. Change amount lemoms per cup | Current amount per cup is {player.recipe.amountOfLemons} \n" +
                            $"3. Change amount cube sugar per cup | Current amount per cup is {player.recipe.amountOfSugarCubes} \n" +
                            $"4. Change amount ice cubes per cup | Current amount per cup is {player.recipe.amountOfIceCubes} \n" +
                            $"5. Exit \n");
                        break;
                    case 4:
                        Console.WriteLine("Write new price: ");
                        player.recipe.amountOfIceCubes = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine($"1. Change price per cup | Current price per cup {player.recipe.pricePerCup} cents\n" +
                            $"2. Change amount lemoms per cup | Current amount per cup is {player.recipe.amountOfLemons} \n" +
                            $"3. Change amount cube sugar per cup | Current amount per cup is {player.recipe.amountOfSugarCubes} \n" +
                            $"4. Change amount ice cubes per cup | Current amount per cup is {player.recipe.amountOfIceCubes} \n" +
                            $"5. Exit \n");
                        break;
                    case 5:
                        Menu();
                        break;
                    default:
                        Console.WriteLine("Choose one of this variants");
                        break;
                }

                value = int.Parse(Console.ReadLine());
            }

        }
        public void Shop()
        {
            Console.WriteLine($"Your balance is: {player.wallet.Money}$");

            player.inventory.ShowInventory();

            Console.WriteLine();

            Console.WriteLine($"" +
                $"1. Buy cup {store.priceCup}$\n" +
                $"2. Buy ice cube {store.pricePerIceCube}$\n" +
                $"3. Buy lemon {store.pricePerLemon}$\n" +
                $"4. Buy sugarCube {store.pricePerSugarCube}$\n\n" +
                $"5. Exit from shop");

            int value = int.Parse(Console.ReadLine());

            while (value != 1 && value != 2 && value != 3 && value != 4 && value != 5)
            {
                Console.WriteLine("Chose one of this variants");
                value = int.Parse(Console.ReadLine());

            }

            while (true)
            {
                switch (value)
                {
                    case 1:
                        if (player.wallet.Money >= store.priceCup)
                        {
                            player.inventory.cups.AddRange(Enumerable.Repeat<Cup>(new Cup(), 10));
                            player.wallet.Money -= store.priceCup;
                            Console.Clear();
                            Console.WriteLine($"Your balance is: {player.wallet.Money}$");

                            player.inventory.ShowInventory();
                            Console.WriteLine();

                            Console.WriteLine($"" +
                                $"1. Buy cup {store.priceCup}$\n" +
                                $"2. Buy ice cube {store.pricePerIceCube}$\n" +
                                $"3. Buy lemon {store.pricePerLemon}$\n" +
                                $"4. Buy sugarCube {store.pricePerSugarCube}$\n\n" +
                                $"5. Exit from shop");
                        }
                        break;
                    case 2:
                        if (player.wallet.Money >= store.pricePerIceCube)
                        {
                            player.inventory.iceCubes.Add(new Player.Invent.Ingredietns.IceCube());
                            player.wallet.Money -= store.pricePerIceCube;
                            Console.Clear();
                            Console.WriteLine($"Your balance is: {player.wallet.Money}$");

                            player.inventory.ShowInventory();
                            Console.WriteLine();

                            Console.WriteLine($"" +
                                $"1. Buy cup {store.priceCup}$\n" +
                                $"2. Buy ice cube {store.pricePerIceCube}$\n" +
                                $"3. Buy lemon {store.pricePerLemon}$\n" +
                                $"4. Buy sugarCube {store.pricePerSugarCube}$\n\n" +
                                $"5. Exit from shop");
                        }
                        break;
                    case 3:
                        if (player.wallet.Money >= store.pricePerLemon)
                        {
                            player.inventory.lemons.Add(new Player.Invent.Ingredietns.Lemon());
                            player.wallet.Money -= store.pricePerLemon;
                            Console.Clear();
                            Console.WriteLine($"Your balance is: {player.wallet.Money}$");

                            player.inventory.ShowInventory();
                            Console.WriteLine();

                            Console.WriteLine($"" +
                                $"1. Buy cup {store.priceCup}$\n" +
                                $"2. Buy ice cube {store.pricePerIceCube}$\n" +
                                $"3. Buy lemon {store.pricePerLemon}$\n" +
                                $"4. Buy sugarCube {store.pricePerSugarCube}$\n\n" +
                                $"5. Exit from shop");
                        }
                        break;
                    case 4:
                        if (player.wallet.Money >= store.pricePerSugarCube)
                        {
                            player.inventory.sugarCubes.Add(new Player.Invent.Ingredietns.SugarCube());
                            player.wallet.Money -= store.pricePerSugarCube;
                            Console.Clear();
                            Console.WriteLine($"Your balance is: {player.wallet.Money}$");

                            player.inventory.ShowInventory();
                            Console.WriteLine();

                            Console.WriteLine($"" +
                                $"1. Buy cup {store.priceCup}$\n" +
                                $"2. Buy ice cube {store.pricePerIceCube}$\n" +
                                $"3. Buy lemon {store.pricePerLemon}$\n" +
                                $"4. Buy sugarCube {store.pricePerSugarCube}$\n\n" +
                                $"5. Exit from shop");
                        }
                        break;
                    case 5:
                        Menu();
                        break;
                    default:
                        Console.WriteLine("Choose one of this variants");
                        break;


                }
                value = int.Parse(Console.ReadLine());
            }
        }
        public void Play()
        {
            Console.Clear();

            for (int i = 0; i < days.Count; i++)
            {
                Console.WriteLine($"Current day {currentDay}");

                for (int j = 0; j < days[i].customers.Count; j++)
                {
                    if (days[i].customers[j].Balance >= player.recipe.pricePerCup &&
                        player.inventory.lemons.Count - player.recipe.amountOfLemons >= 0 &&
                        player.inventory.sugarCubes.Count - player.recipe.amountOfSugarCubes >= 0 &&
                        player.inventory.iceCubes.Count - player.recipe.amountOfIceCubes >= 0)
                    {
                        player.wallet.Money += player.recipe.pricePerCup;
                        Console.WriteLine($"You earned {player.recipe.pricePerCup} cents");
                        Thread.Sleep(1000);

                        player.inventory.iceCubes.RemoveRange(0, player.recipe.amountOfIceCubes);
                        player.inventory.lemons.RemoveRange(0, player.recipe.amountOfLemons);
                        player.inventory.sugarCubes.RemoveRange(0, player.recipe.amountOfSugarCubes);

                    }
                    else if (player.inventory.lemons.Count - player.recipe.amountOfLemons < 0 &&
                        player.inventory.sugarCubes.Count - player.recipe.amountOfSugarCubes < 0 &&
                        player.inventory.iceCubes.Count - player.recipe.amountOfIceCubes < 0)
                    {
                        Console.WriteLine("Sold out");
                        Thread.Sleep(1000);
                        break;
                    }

                }

                currentDay++;
            }

            Menu();
        }







    }

}

