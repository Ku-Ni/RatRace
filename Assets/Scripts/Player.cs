using UnityEngine;
using System.Collections;
using System;
using DG.Tweening;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour {
    private Location playerLocation;
    private Transform playerTransform;
    private float yPos;

	// Use this for initialization
	void Start () {
        playerTransform = GetComponent<Transform>();
        yPos = playerTransform.position.y;
        // TODO: Store home location
        foreach (Location location in GameObject.FindObjectsOfType<Location>()) {
            if (location.GetName() == "LowCostHousing") {
                playerLocation = location;
            }
        }
    }
	
    /// <summary>
    /// 
    /// </summary>
    /// <param name="location"></param>
    internal void SetLocation(Location location) {
        playerLocation = location;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="location"></param>
    public void MoveTo(float xPos, float zPos, float duration) {
        transform.DOMove(new Vector3(xPos, yPos, zPos), duration);
        Debug.Log("Player position: " + transform.position + "\n" + playerLocation + " position: " + playerLocation.GetEntranceTransform().position);
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
