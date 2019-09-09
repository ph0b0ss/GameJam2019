using System;
using System.Collections;
using System.Collections.Generic;
using Rewired;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public enum MenuState { Menu = 0, CharacterSelection = 1, Game = 2}
public class UiMenuController : MonoBehaviour
{
    [SerializeField] private Canvas _menuCanvas;
    [SerializeField] private Canvas _characterSelectionCanvas;
    [SerializeField] private Canvas _gameCanvas;
    [SerializeField] private CamerasController _camerasController;
    [SerializeField] private GameLogic _gameLogic;

    public MenuState state;
    
    public void GotoMenu()
    {
        _gameCanvas.enabled = false;
        _characterSelectionCanvas.enabled = false;
        _menuCanvas.enabled = true;
        _camerasController.ActivateMenuCamera(true);
        state = MenuState.Menu;
    }
    
    public void GotoCharacterSelection()
    {
        _gameCanvas.enabled = false;
        _menuCanvas.enabled = false;
        _characterSelectionCanvas.enabled = true;
        _camerasController.ActivateMenuCamera(true);
        state = MenuState.CharacterSelection;
    }
    
    public void GotoGame()
    {
        _gameCanvas.enabled = true;
        _menuCanvas.enabled = false;
        _characterSelectionCanvas.enabled = false;
        _camerasController.ActivateMenuCamera(false);
        state = MenuState.Game;
        _gameLogic.NewGame();
    }

    private void Awake()
    {
        _gameLogic.OnStateChanged += GameLogicOnOnStateChanged;
    }

    private void GameLogicOnOnStateChanged()
    {
        if (!_gameLogic.Playing)
        {
            if (IsInvoking()) return;
            Invoke("GotoMenu", 5);
        }
    }

    private void Update()
    {
        if (state == MenuState.CharacterSelection)
        {
            if (ReInput.controllers.GetAnyButton())
            {
                GotoGame();
            }
        }
    }
}
