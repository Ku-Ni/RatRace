using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using UnityEngine;

public class StoreManager : MonoBehaviour {
    private StoreItemsContainer storeItemsContainer;
    public string storeItemsPath = "data/StoreItems.xml";

    // Use this for initialization
    void Start () {
        Debug.Log("StoreManager initialising...");
        storeItemsContainer = LoadStoreItemsContainer();
        Debug.Log("StoreItemsContainer: " + storeItemsContainer.ToString());
    }
	

    private StoreItemsContainer LoadStoreItemsContainer() {
        Debug.Log("Datapath: " + System.IO.Path.Combine(Application.dataPath, storeItemsPath));
        var serializer = new XmlSerializer(typeof(StoreItemsContainer));

        using (var stream = new FileStream(System.IO.Path.Combine(Application.dataPath, storeItemsPath), FileMode.Open)) {
            return serializer.Deserialize(stream) as StoreItemsContainer;
        }
    }

    public List<StoreItem> GetStoreItems(string storeName) {
        Debug.Log("StoreName: " + storeName);
        if (storeItemsContainer == null)
        {
            storeItemsContainer = LoadStoreItemsContainer();
        }
        Debug.Log("StoreItemsContainer: " + storeItemsContainer.ToString());
        return storeItemsContainer.GetStoreItems(storeName);
    }
}
