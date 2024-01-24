using System.IO.Pipes;

namespace Items {

    public class Potion : Item
    {
        public Potion (string itemName, string itemDescription) : base(itemName, itemDescription)
        {
            
        }
        public void UseOnSelf()
        {
            Console.WriteLine("You have used the " + itemName + " on yourself.");
        }
        public void UseOnEnemy()
        {
            Console.WriteLine("You have used the " + itemName + " on the enemy.");
        }
    }    
}