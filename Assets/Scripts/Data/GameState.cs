using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Game state", menuName = "Custom/Game State")]
public class GameState : ScriptableObject
{
    public int activePlayers = 0;
    public int teamA = 0;
    public int teamB = 0;

    private void ResetToDefaults()
    {
        activePlayers = 0;
        teamA = 0;
        teamB = 0;
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
