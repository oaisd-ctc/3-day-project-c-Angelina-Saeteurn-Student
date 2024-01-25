using System.IO.Pipes;

namespace Items {

    public class HealPotion: Potion
    {
        
        public HealPotion (string itemName, string itemDescription) : base(itemName, itemDescription)
        {
            
        }
        public void UseOnSelf()
        {
            Console.WriteLine("You have used the Healing Potion on yourself.");
        }
        public void UseOnEnemy()
        {
            Console.WriteLine("You have used the Healing Potion on the enemy. (Why did you do that?)");
        }
    }    
}