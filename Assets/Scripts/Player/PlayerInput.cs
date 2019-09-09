using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rewired;

public class PlayerInput : PlayerBehaviour
{
    void Update()
    {
        if (!playerState.isAlive) return;

        if (playerState.IsControllable)
        {
            playerState.horizontalInput = ReInput.players.GetPlayer(configuration.rewiredPlayerID).GetAxis("Horizontal");
            playerState.verticalInput = ReInput.players.GetPlayer(configuration.rewiredPlayerID).GetAxis("Vertical");
            playerState.pushInput = ReInput.players.GetPlayer(configuration.rewiredPlayerID).GetButtonDown("Push");
        }
        else
        {
            playerState.horizontalInput = 0f;
            playerState.verticalInput = 0f;
            playerState.pushInput = false;
        }
    }
}
