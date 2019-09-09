using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : PlayerBehaviour
{
    public Animator playerAnimator;
    private static readonly int RunSpeed = Animator.StringToHash("RunSpeed");

    public 

    void Update()
    {
        if (!playerState.isAlive) return;
        if (playerAnimator == null) return;

        playerAnimator.SetFloat(RunSpeed, playerState.velocity.normalized.sqrMagnitude);
        playerAnimator.SetBool("Pushing", playerState.isPushing);
        playerAnimator.SetBool("Collision", !playerState.isPushing && !playerState.IsControllable);
    }
}
