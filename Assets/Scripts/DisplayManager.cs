using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class DisplayManager : MonoBehaviour {
    private List<GameObject> displayObjects;
    private GameObject storeDisplay;
    private GameObject workDisplay;

    // Use this for initialization
    void Start() {
        displayObjects = new List<GameObject>(GameObject.FindGameObjectsWithTag("display"));
        foreach (GameObject displayObject in displayObjects) {
            displayObject.SetActive(false);

            if (displayObject.name == "StoreDisplay")
                storeDisplay = displayObject;
            else if (displayObject.name == "WorkDisplay")
                workDisplay = displayObject;
        }
        
    }

    /// <summary>
    /// 
    /// </summary>
    public void Deactivate() {
        foreach(GameObject display in displayObjects){
            display.SetActive(false);
        }        
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="store"></param>
    public void DisplayStore(Store store) {
        Text text = storeDisplay.GetComponentInChildren<Text>();
        List<StoreItem> storeItems = store.GetItems();

        foreach (StoreItem item in storeItems) {
            text.text += item.ToString();
            text.text += Environment.NewLine;
        }

        storeDisplay.SetActive(true);

    }
}
