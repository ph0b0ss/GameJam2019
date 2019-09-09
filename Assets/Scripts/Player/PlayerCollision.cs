using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : PlayerBehaviour
{
    private bool processCollision;
    private Collision collisionData;

    private void Update()
    {
        if (!playerState.isAlive) return;

        if (processCollision)
        {
            playerState.isPushing = false;
            playerState.collision = true;

            playerState.nextControllableTime = Time.time + configuration.recoveryTime;
            playerState.pushChargeValue += configuration.pushChargePerCollision;

            if (collisionData.collider.CompareTag("Dynamic"))
            {
                playerState.velocity = (collisionData.relativeVelocity + (playerState.velocity * 0.66f)).magnitude * collisionData.GetContact(0).normal;
            }
            else
            {
                playerState.velocity = Vector3.Reflect(playerState.velocity, collisionData.GetContact(0).normal);
            }

            processCollision = false;
        }
        else
        {
            playerState.collision = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!processCollision)
        {
            processCollision = true;
            collisionData = collision;
        }
    }
}
