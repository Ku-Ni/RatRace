using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

// http://wiki.unity3d.com/index.php?title=Saving_and_Loading_Data:_XmlSerializer
[XmlRoot("StoreItemList")]
public class StoreItemsContainer {

    [XmlArray("Stores"), XmlArrayItem("Store")]
    public List<StoreItems> storeItems;
    
    public List<StoreItem> GetStoreItems(string storeName) {
        foreach (StoreItems store in storeItems) {
            if (store.storeName.Equals(storeName))
                return store.storeItems;
        }

        return null;
    }


    public class StoreItems {
        [XmlAttribute("StoreName")]
        public string storeName;

        [XmlArray("StoreItems"), XmlArrayItem("StoreItem")]
        public List<StoreItem> storeItems;

    }
    
}
