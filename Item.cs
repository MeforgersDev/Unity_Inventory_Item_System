public enum ItemType
{
    Weapon,
    Consumable,
    Armor,
    Misc
}

[System.Serializable]
public class Item
{
    public string itemName;
    public string description;
    public ItemType itemType;
    public int value;
    public Sprite icon;
}
