using System.Collections;
using System.Collections.Generic;
using Cinemachine.Utility;
using UnityEngine;

public class PlayerMovement : PlayerBehaviour
{
    [SerializeField] private Transform _mainCamera;
    void Update()
    {
        if (!playerState.isAlive) return;

        if (playerState.IsControllable)
        {
            //playerState.velocity = new Vector3(playerState.horizontalInput, 0, playerState.verticalInput) * configuration.speed;
            //playerState.velocity = (_mainCamera.forward * playerState.verticalInput + _mainCamera.right * playerState.horizontalInput) * configuration.speed;
            Vector3 newCoor = (_mainCamera.forward * playerState.verticalInput + _mainCamera.right * playerState.horizontalInput) * configuration.speed;
            playerState.velocity = newCoor.normalized.ProjectOntoPlane(Vector3.up) * configuration.speed;
            if (playerState.velocity.sqrMagnitude > 0.01f)
            {
                playerRigidbody.MoveRotation(Quaternion.LookRotation(playerState.velocity));
            }
        }
        else if (!playerState.isPushing)
        {
            playerState.velocity *= 0.95f;
        }

        playerRigidbody.velocity = playerState.velocity;
    }
}
