using UnityEngine;
using System.Collections;
using System;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour {
    private Location playerLocation;
    private Transform playerTransform;

	// Use this for initialization
	void Start () {
        playerTransform = GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    /// <summary>
    /// 
    /// </summary>
    /// <param name="location"></param>
    public void GoTo(Location location) {
        playerLocation = location;
        Transform entranceTransform = location.GetEntranceTransform();
        playerTransform.position = new Vector3(entranceTransform.position.x, playerTransform.position.y, entranceTransform.position.z);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public Location GetLocation() {
        return playerLocation;
    }

    /// <summary>
    /// 
    /// </summary>
    public void ExitLocation() {
        playerLocation.PlayerExits();
        playerLocation = null;
    }

}
