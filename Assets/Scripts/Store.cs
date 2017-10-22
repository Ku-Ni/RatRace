using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
[RequireComponent(typeof(Location))]
public class Store : MonoBehaviour {
    private List<StoreItem> items;
    private StoreManager storeManager;
    private GameManager gameManager;

    // Use this for initialization
    void Start() {
        storeManager = GameObject.FindObjectOfType<StoreManager>();
        items = storeManager.GetStoreItems(name);
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    public List<StoreItem> GetItems() {
        return items;
    }
}
