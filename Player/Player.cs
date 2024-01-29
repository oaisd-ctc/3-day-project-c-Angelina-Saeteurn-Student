using Items;
public class Player
{

    private int health;
    private string name;
    private Weapon weapon;
    private Potion[] inventory = new Potion[5];
    private Potion empty = new Potion("EMPTY", "EMPTY");

    public Player(string name, Potion startingPotion, Weapon weapon)
    {
        this.name = name;
        this.weapon = weapon;
        health = 100;

        inventory[0] = startingPotion;
        inventory[1] = empty;
        inventory[2] = empty;
        inventory[3] = empty;
        inventory[4] = empty;
    }
    public void SubtractHealth(int Damage)
    {
        health = health - Damage;
    }

    public void SetName(string newName)
    {
        name = newName;
    }

    public string GetName() {
        return name;
    }

    public int GetHealth()
    {
        return health;
    }

    public void SetHealth(int addHealth)
    {
        health += addHealth;
    }

    public string GetWeapon() {
        return weapon.GetItemName();
    }

    public Potion[] GetInventory() {
        return inventory;
    }

}