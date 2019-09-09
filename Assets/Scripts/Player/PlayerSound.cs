using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSound : PlayerBehaviour
{
    public AudioSource audioSource;
    public AudioClip collisionClip;
    public AudioClip pushClip;

    // Update is called once per frame
    void Update()
    {
        if (!playerState.isAlive) return;

        if (playerState.collision)
        {
            audioSource.PlayOneShot(collisionClip);
        }
        else if (playerState.pushInput && playerState.isPushing && !audioSource.isPlaying)
        {
            audioSource.PlayOneShot(pushClip);
        }
    }
}
