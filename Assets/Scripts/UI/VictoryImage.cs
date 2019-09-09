using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VictoryImage : MonoBehaviour
{
    public GameState gameState;

    public Image victoryImage;

    public Sprite teamAVictorySprite;
    public Sprite teamBVictorySprite;

    private void Start()
    {
        victoryImage.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameState.activePlayers > 0)
        {
            if (gameState.teamA == 0)
            {
                victoryImage.sprite = teamAVictorySprite;
                victoryImage.enabled = true;
                enabled = false;
            }
            else if (gameState.teamB == 0)
            {
                victoryImage.sprite = teamBVictorySprite;
                victoryImage.enabled = true;
                enabled = false;
            }
        }
        else
        {
            Debug.Log("It's a draw!");
        }
    }
}

