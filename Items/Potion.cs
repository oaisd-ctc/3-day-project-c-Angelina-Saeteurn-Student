using System.IO.Pipes;
using System.Runtime.CompilerServices;

namespace Items {

    public class Potion : Item
    {
        public Potion (string itemName, string itemDescription) : base(itemName, itemDescription)
        {
            
        }
        public virtual void UseOnPlayer(Player Character)
        {
            Console.WriteLine($"{Character} has used the {itemName}.");
        }
        public virtual void UseOnEnemy(Enemy Villian)
        {
            Console.WriteLine($"You have used the {itemName} on the {Villian}.");
        }
    }    
}