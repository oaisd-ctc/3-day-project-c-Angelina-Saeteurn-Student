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

        public virtual void Attack()
        {
            //You've Mucho-ed your last mango
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