﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {
    // TODO: Move to PlayerManager
    List<Player> players;
    int activePlayer;

    // Use this for initialization
    void Start () {
        players = new List<Player>();
        AddPlayer(GameObject.FindObjectOfType<Player>());
        activePlayer = 0;

    }

    public Player GetActivePlayer() {
        return players[activePlayer];
    }

    public void NextPlayer() {
        activePlayer++;

        if (activePlayer == players.Count) {
            activePlayer = 0;
        }
    }

    public void MovePlayer(Location location) {
        Player activePlayer = GetActivePlayer();
        activePlayer.SetLocation(location);
        Transform entranceTransform = location.GetEntranceTransform();

        activePlayer.MoveTo(entranceTransform.position.x, entranceTransform.position.z, 1f);
    }

    public void AddPlayer(Player player) {
        players.Add(player);
    }
}
