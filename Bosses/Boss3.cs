using System.Linq.Expressions;
namespace Enemies{
    public class Boss3 : Enemy
    {
        public string name;
        public int health;
        public int minDamage;
        public int maxDamage;
        public bool effectedByPotions;
        public string enemyLocation;

        public Boss3(string name, int health, int minDamage, int maxDamage, bool effectedByPotions, string enemyLocation) : base(name, health, minDamage, maxDamage, effectedByPotions, enemyLocation)
        {
            //The Infernal Warlord, Emannuel The Scorched Conquerer
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
            if (damage==20){
                Console.WriteLine($"It's time for box breathing. Inhale....... hold it........ (He doesn't say anything else, you're forced to hold it you take {damage} damage)");
            }
            else if(damage<=25){
                Console.WriteLine($"You're not sitting at your desk. He marks you tardy. You take {damage} emotional damage.");
            }
            else if(damage<=35){
                Console.WriteLine($"It was going to be a snow day but he summons a fire ball melting the snow. Dude my snow day!? You take {damage} damage.");
            }
            else if(damage<45){
                Console.WriteLine($"Is he pulling out a flamethrower? lskdklsdflskdf;lsdfksdlfj'klf';klsfd (Kentucky Fried Player... you take {damage} Damage)");
            }
            else if(damage==45){
                Console.WriteLine($"He holds out a piece of paper, ITS YOUR TEST, IT HAS AN F ON IT you failed you test :( you take {damage} damage");
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

        public int SetHealth(int damage)
        {
            return health - damage;
        }
            public string GetName()
        {
            return name;
        }
    }
}