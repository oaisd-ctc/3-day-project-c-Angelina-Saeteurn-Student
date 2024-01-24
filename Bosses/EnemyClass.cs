using System.Linq.Expressions;

public class Enemy
{
    public string name;
    public int health;
    public int minDamage;
    public int maxDamage;
    public bool effectedByPotions;

    public Enemy(string name, int health, int minDamage, int maxDamage, bool effectedByPotions)
    {
        this.name = name;
        this.health = health;
        this.minDamage = minDamage;
        this.maxDamage = maxDamage;
        this.effectedByPotions = effectedByPotions;
    }

    public virtual void Action1()
    {
        //Boss attacks? or does an action.
    }
    
        public virtual void Action2()
    {
        //Boss attacks? or does an action.
    }

}