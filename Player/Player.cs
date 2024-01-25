using Items;
public class Player {

    private int health;
    private string name;
    private Item weapon;
    private Item[] inventory = new Item[4];

    public Player(string name, Item startingPotion, Item weapon) {
        this.name = name;
        this.weapon = weapon;
        health = 100;
        
        inventory[0] = weapon;
        inventory[1] = startingPotion;
    }

    public void SetName(string newName) {
        name = newName;
    }

    public int GetHealth() {
        return health;
    }

    public void SetHealth(int addHealth) {
        health += addHealth;
    }

}