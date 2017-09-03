using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    


	// Use this for initialization
	void Start () {
        GetComponent<DisplayManager>().Deactivate();        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public PlayerManager GetPlayerManager() {
        return GetComponent<PlayerManager>();
    }

    public StoreManager GetStoreManager() {
        return GetComponent<StoreManager>();
    }

}
