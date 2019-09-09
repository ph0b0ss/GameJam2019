using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player state", menuName = "Custom/Player State")]
public class PlayerState : ScriptableObject
{
    public bool isAlive = true;

    public Vector3 velocity;
    
    public float nextControllableTime = -1;

    public float horizontalInput;
    public float verticalInput;
    public bool pushInput;

    public bool collision = false;

    public bool isPushing = false;
    public float pushChargeValue = 0;

    public bool IsControllable
    {
        get { return nextControllableTime < Time.time; }
    }

    public bool CanPush
    {
        get { return pushChargeValue >= 1; }
    }

    private void ResetToDefaults()
    {
        isAlive = true;
        velocity = Vector3.zero;
        nextControllableTime = -1;
        horizontalInput = 0;
        verticalInput = 0;
        pushInput = false;
        collision = false;
        isPushing = false;
        pushChargeValue = 0;
    }

    private void OnEnable()
    {
        ResetToDefaults();
    }

    private void OnDisable()
    {
        ResetToDefaults();
    }
}
