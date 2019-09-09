using UnityEngine;

public abstract class PlayerBehaviour : MonoBehaviour
{
    protected PlayerConfiguration configuration;
    protected PlayerState playerState;

    protected Transform playerTransform;
    protected Rigidbody playerRigidbody;

    private void Awake()
    {
        enabled = false;
    }

    public void Initialize(PlayerConfiguration config, PlayerState state)
    {
        configuration = config;
        playerState = state;

        playerTransform = transform;
        playerRigidbody = GetComponent<Rigidbody>();

        enabled = true;
    }
}