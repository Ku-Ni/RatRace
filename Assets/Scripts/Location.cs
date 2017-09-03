using System;
using UnityEngine;

/// <summary>
/// 
/// </summary>
[RequireComponent(typeof(BoxCollider))]
public class Location : MonoBehaviour {
    public bool isPlaceOfWork = false;

    private GameObject entranceLocation;
    private bool isTriggered = false;

    // Use this for initialization
    void Start() {
        foreach (Transform t in transform) {
            if (t.name == "EntranceLocation") {
                entranceLocation = t.gameObject;
            }
        }

        if (entranceLocation == null) {
            throw new ArgumentNullException("EntranceLocation must be supplied for all Location objects");
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public void PlayerExits() {
        isTriggered = false;
    }

    /// <summary>
    /// 
    /// </summary>
    public void OnMouseDown() {
        GameObject.FindObjectOfType<PlayerManager>().MovePlayer(this);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="other"></param>
    public void OnTriggerStay(Collider other) {

        if (!isTriggered) {

            Player p = other.GetComponent<Player>();

            if (p != null) {
                if (p.GetLocation() == this) {
                    isTriggered = true;
                }
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns>Location.name</returns>
    public string GetName() {
        return this.name;
    }

    /// <summary>
    /// Get EntranceLocation for selected Location
    /// </summary>
    /// <returns>location.transform.GetChild(1)</returns>
    public Transform GetEntranceTransform() {
        return this.transform.GetChild(1);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns>transform.GetChild(0).gameObject</returns>
    public GameObject GetEntrance() {
        return transform.GetChild(0).gameObject;
    }


}
