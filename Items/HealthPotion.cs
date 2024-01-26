using System.IO.Pipes;
using Enemies;


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
        public virtual void UseOnEnemy(Enemy Villian)
        {
            Console.WriteLine($"You used the Health Potion on the enemy. (Why did you do that.)");
        }
    }    
}