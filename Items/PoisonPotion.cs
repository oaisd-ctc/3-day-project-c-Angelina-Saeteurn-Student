using System.IO.Pipes;

namespace Items {

    public class PoisonPotion: Potion
    {
        
        public PoisonPotion (string itemName, string itemDescription) : base(itemName, itemDescription)
        {
            
        }
        public override void UseOnPlayer(Player Character)
        {
            Console.WriteLine("You have used the Poison Potion on yourself. (Ouch!)");
        }
        public override void UseOnEnemy(Enemy Villian)
        {
            Console.WriteLine("You have used the Poison Potion on the enemy.");
        }
    }    
}