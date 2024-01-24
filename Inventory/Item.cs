public class Item {

    protected string itemName;
    protected string itemDescription;

    public Item(string itemName, string itemDescription) {
        this.itemName = itemName;
        this.itemDescription = itemDescription;
    }

        public string GetItemName() {
        return itemName;
    }

    public string GetItemDescription() {
        return itemDescription;
    }
}