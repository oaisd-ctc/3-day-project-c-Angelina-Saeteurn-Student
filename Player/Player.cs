using Items;
public class Player
{

    private int health;
    private string name;
    private Weapon weapon;
    private Potion[] inventory = new Potion[4];

    public Player(string name, Potion startingPotion, Weapon weapon)
    {
        this.name = name;
        this.weapon = weapon;
        health = 100;

        inventory[0] = startingPotion;
    }

    public void SetName(string newName)
    {
        name = newName;
    }

    public int GetHealth()
    {
        return health;
    }

    public void SetHealth(int addHealth)
    {
        health += addHealth;
    }

    public Weapon GetWeapon() {
        return weapon;
    }

    public Potion[] GetInventory() {
        return inventory;
    }

}