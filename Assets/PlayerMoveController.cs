using System;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerMoveController : MonoBehaviour {
    private PlayerManager playerManager;
    public List<Location> locations;

	// Use this for initialization
	void Start () {
        playerManager = GameObject.FindObjectOfType<PlayerManager>();
	}

    public void MoveActivePlayer(Location destinationLocation) {
        int currentIndex = locations.IndexOf(playerManager.GetActivePlayer().GetLocation());
        Debug.Log("Current location: " + playerManager.GetActivePlayer().GetLocation());
        Debug.Log("Current index:    " + currentIndex);
        int destinationIndex = locations.IndexOf(destinationLocation);
        int direction = CalculateDirection(currentIndex, destinationIndex);

        List<Location> moves = new List<Location>();
        Location nextLocation = null;
        while (nextLocation != destinationLocation) {
            currentIndex = currentIndex + direction;
            if (currentIndex < 0)
                currentIndex = locations.Count - 1;
            if (currentIndex > locations.Count - 1)
                currentIndex = 0;

            nextLocation = locations[currentIndex];
            moves.Add(nextLocation);
        }

        foreach (Location location in locations) {
            playerManager.MovePlayer(location);
        }

    }

    private int CalculateDirection(int current, int destination) {
        // Set standard direct direction
        int direction = current < destination ? 1 : -1;
        int directDistance = Math.Abs(current - destination);
        if (directDistance < (locations.Count - directDistance)) {
            return direction;
        }
        else {
            // quicker to go opposite direction
            return -direction;
        }
    }
}
