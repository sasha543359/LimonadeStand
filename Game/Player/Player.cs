using ConsoleApp1.Game.Player.Inventory;
using ConsoleApp1.Game.Player.Recipe;

namespace ConsoleApp1.Game.Player
{
    public class Player
    {
        public string name { get; set; } = string.Empty;
        public Inventory.Inventory inventory { get; set; }

        public Wallet.Wallet wallet { get; set; }

        public Recipe.Recipe recipe { get; set; }

        public Player(string name, Inventory.Inventory inventory, Wallet.Wallet wallet, Recipe.Recipe recipe)
        {
            this.name = name;
            this.inventory = inventory;
            this.wallet = wallet;
            this.recipe = recipe;
        }



    }
}
