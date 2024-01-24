public class Player {

    private int health;
    private string name;
    private string weapon;
    private string[] inventory = new string[4];

    public Player(string name, string startingPotion, string weapon) {
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

    public string GetInventory() {
        return inventory[0];
        
    }

}