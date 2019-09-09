using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFall : PlayerBehaviour
{
    private bool processFall;

    private void Update()
    {
        if (!playerState.isAlive) return;

        if (processFall)
        {
            Destroy(Instantiate(configuration.deathParticleSystem, playerTransform.position, Quaternion.identity), 2f);

            playerState.isAlive = false;
            playerState.velocity = Vector3.zero;

            processFall = false;

            playerTransform.gameObject.SetActive(false);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        processFall = true;
    }
}
