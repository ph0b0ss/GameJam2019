using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player Configuration", menuName = "Configuration/Player")]
public class PlayerConfiguration : ScriptableObject
{
    public int rewiredPlayerID;
    public KeyCode leftKey;
    public KeyCode rightKey;
    public KeyCode pushKey;

    public float speed;

    public float pushSpeed;
    public float pushChargePerCollision;

    public float recoveryTime;

    public GameObject deathParticleSystem;
    
}
