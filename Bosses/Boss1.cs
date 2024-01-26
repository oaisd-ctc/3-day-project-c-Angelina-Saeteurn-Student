using System.Linq.Expressions;
namespace Enemies{
    public class Boss1 : Enemy
    {
        public string name;
        public int health;
        public int minDamage;
        public int maxDamage;
        public bool effectedByPotions;
        public string enemyLocation;

        public Boss1(string name, int health, int minDamage, int maxDamage, bool effectedByPotions, string enemyLocation) : base(name, health, minDamage, maxDamage, effectedByPotions, enemyLocation)
        {
            //The Frugal Financier, Aedan the Penny-Pinching Tycoon
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
            if (damage==1){
                Console.WriteLine("He takes out a penny, and throws it at you, it lands on top of your head... Ow, you take 1 emotional damage.");
            }
            else if(damage<=5){
                Console.WriteLine($"He takes a doller bill and rips it in half... why did he do that ... you take {damage} emotional damage.");
            }
            else if(damage<=10){
                Console.WriteLine($" he shakes a can of Arizona brand Mucho Mango, and it explodes, gross, you take {damage} damage.");
            }
            else if(damage<20){
                Console.WriteLine($"he just straight up throws a can at you, it hits you in the head, YEOUCH! You take {damage} damage.");
            }
            else if(damage==20){
                Console.WriteLine("'You've Mucho-ed your last mango' He takes out a cash gun and KABOOM, You take 20 damage.");
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