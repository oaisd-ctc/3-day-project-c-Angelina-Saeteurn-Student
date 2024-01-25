using System.IO.Pipes;

namespace Items {

    public class HealthPotion: Potion
    {
        
        public HealthPotion (string itemName, string itemDescription) : base(itemName, itemDescription)
        {
            
        }
        public virtual void UseOnPlayer(Player Character)
        {
            Console.WriteLine($"{Character} has used the Health Potion.");
        }
        public virtual void UseOnEnemy(Player Character)
        {
            Console.WriteLine($"{Character} used the Health Potion on the enemy. (Why did you do that.)");
        }
    }    
}