using System.IO.Pipes;
using Enemies;

namespace Items {

    public class FireResistance: Potion
    {
        
        public FireResistance (string itemName, string itemDescription) : base(itemName, itemDescription)
        {
            
        }
        public override void UseOnPlayer(Player Character)
        {
            Console.WriteLine("You have used the Fire Resistance Potion on yourself.");
        }
        public override void UseOnEnemy(Enemy Villian)
        {
            Console.WriteLine("You have used the Fire Resistance Potion on the enemy. (What the heck?!)");
        }
    }    
}