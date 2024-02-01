using System.Linq.Expressions;
namespace Enemies{
    public class Boss2 : Enemy
    {
        public string name;
        public int health;
        public int minDamage;
        public int maxDamage;
        public bool effectedByPotions;
        public string enemyLocation;

        public Boss2(string name, int health, int minDamage, int maxDamage, bool effectedByPotions, string enemyLocation) : base(name, health, minDamage, maxDamage, effectedByPotions, enemyLocation)
        {
            // The Enigmatic Soverign, Mister Luyk the Arcane Luminary
            this.name = name;
            this.health = health;
            this.minDamage = minDamage;
            this.maxDamage = maxDamage;
            this.effectedByPotions = effectedByPotions;
            this.enemyLocation = enemyLocation;
        }

        public override int Attack()
        {
            Random Ran = new Random();
            int damage = Ran.Next(minDamage,maxDamage);
            if (damage==10){
                Console.WriteLine($"He goes in for a fistbump and it statically shocks you, ow, you take {damage} damage");
            }
            else if(damage<=15){
                Console.WriteLine($"He scoffs at your code. Take {damage} emotional damage.");
            }
            else if(damage<=25){
                Console.WriteLine($"He takes out a shovel, scoops up some snow and launches it at you, you take {damage} damage.");
            }
            else if(damage<35){
                Console.WriteLine($"'It's time for my new spell, The Baja Blast Freeze!' That was cold you take {damage} damage.");
            }
            else if(damage==35){
                Console.WriteLine($"'Here's your daily logic' NOOOOOOOOOO you take {damage} Damage.");
            }
            return damage;
        }

        public virtual void Action2()
        {
            //Boss attacks? or does an action.
        }

        public int GetHealth()
        {
            return health;
        }

        public int SetHealth()
        {
            return health;
        }
            public string GetName()
        {
            return name;
        }
    }
}