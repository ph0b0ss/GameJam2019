using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPush : PlayerBehaviour
{
    private void Update()
    {
        if (!playerState.isAlive) return;

        if (playerState.IsControllable)
        {
            playerState.isPushing = false;
        }

        if (playerState.CanPush)
        {
            if (playerState.pushInput)
            {
                playerState.velocity = configuration.pushSpeed * playerTransform.forward;
                playerState.isPushing = true;
                playerState.pushChargeValue = 0;
                playerState.nextControllableTime = Time.time + configuration.recoveryTime;
            }
        }
    }
}
