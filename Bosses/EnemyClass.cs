using System.Linq.Expressions;

public class Enemy
{
    public string name;
    public int health;
    public int minDamage;
    public int maxDamage;
    public bool effectedByPotions;
    public string enemyLocation;

    public Enemy(string name, int health, int minDamage, int maxDamage, bool effectedByPotions, string enemyLocation)
    {
        this.name = name;
        this.health = health;
        this.minDamage = minDamage;
        this.maxDamage = maxDamage;
        this.effectedByPotions = effectedByPotions;
        this.enemyLocation = enemyLocation;
    }

    public virtual void Action1()
    {
        //Boss attacks? or does an action.
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