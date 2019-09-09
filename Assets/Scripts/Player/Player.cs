using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerConfiguration configuration;
    public PlayerState playerState;

    public PlayerBehaviour[] playerBehaviours;

    void Start()
    {
        if (!playerState.isAlive)
        {
            Destroy(gameObject);
            return;
        }

        foreach(PlayerBehaviour pb in playerBehaviours)
        {
            pb.Initialize(configuration, playerState);
        }
    }
}
