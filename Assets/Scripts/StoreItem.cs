

using System.Xml.Serialization;

public class StoreItem {
    [XmlAttribute("ItemName")]
    public string ItemName;

    // TODO: Create Enum for ItemType
    public string type;
    public float cost;

    override public string ToString() {
        return ItemName + " (" + type + ") " + cost;
    }
}
