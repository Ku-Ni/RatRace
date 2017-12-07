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
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    internal void SetLocation(Location location) {
        playerLocation = location;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="location"></param>
    public void MoveTo(float xPos, float zPos, float duration) {
        transform.DOMove(new Vector3(xPos, yPos, zPos), duration);
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
