using System;
using System.Collections;
using System.Collections.Generic;
using Rewired;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public GameState gameState;

    public PlayerState[] playerStates;

    private bool _playing;

    public bool Playing
    {
        get => _playing;
        private set
        {
            bool changed = value;
            if (changed != _playing)
            {
                changed = true;
            }
            _playing = value;
            if (changed)
            {
                OnStateChanged?.Invoke();
            }
        }
    }


    public event Action OnStateChanged;

    private void Awake()
    {
        foreach (PlayerState ps in playerStates)
        {
            ps.nextControllableTime = float.MaxValue;
        }
    }


    public void NewGame()
    {
        CountPlayersPerTeam();
        Playing = true;
        OnStateChanged?.Invoke();

        foreach (PlayerState ps in playerStates)
        {
            ps.nextControllableTime = Time.time + 1;
        }
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Playing = false;
            return;
        }
        if (!Playing) return;

        CountPlayersPerTeam();

        if (gameState.activePlayers > 0)
        {
            if (gameState.teamA == 0)
            {
                Debug.Log("Team A wins");
                Playing = false;
            }
            else if (gameState.teamB == 0)
            {
                Debug.Log("Team B wins");
                Playing = false;
            }
        }
        else
        {
            Debug.Log("It's a draw!");
        }
    }

    private void CountPlayersPerTeam()
    {
        gameState.activePlayers = 0;
        gameState.teamA = 0;
        gameState.teamB = 0;

        for (int i = 0; i < playerStates.Length; i++)
        {
            if (playerStates[i].isAlive)
            {
                gameState.activePlayers++;

                if ((i & 1) != 0)
                {
                    gameState.teamA++;
                }
                else
                {
                    gameState.teamB++;
                }
            }
        }
    }
}