using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerBar : MonoBehaviour
{
    public PlayerState playerState;

    public Image shineBackground;
    public Image powerFill;

    private void Awake()
    {
        if (!playerState.isAlive)
        {
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerState.isAlive)
        {
            gameObject.SetActive(false);
        }
        else
        {
            shineBackground.enabled = playerState.CanPush;
            powerFill.fillAmount = playerState.pushChargeValue;
        }
        
    }
}

