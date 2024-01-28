namespace Items {
    public class Weapon : Item {

    private int minimumDamage;
    private int maximumDamage;


        public Weapon(string itemName, string itemDescription) : base (itemName, itemDescription) {
            
        }


    public Weapon(string itemName, string itemDescription, int minimumDamage, int maximumDamage) : base (itemName, itemDescription) {
        this.minimumDamage = minimumDamage;
        this.maximumDamage = maximumDamage;
    }


    public void SetMinimumDamage(int newMinimumDamage) {
        minimumDamage = newMinimumDamage;
    }

    public void SetMaximumDamage(int newMaximumDamage) {
        maximumDamage = newMaximumDamage;
    }

    public void Attack(int bossHealth) {
        Random rnd = new Random();
        int attackDamage = rnd.Next(minimumDamage, maximumDamage++);

        bossHealth -= attackDamage;
    }
    
    public string getDamageRange()
    {
        string damageRange = minimumDamage + " " + maximumDamage;
        return damageRange;
    }



    }
}