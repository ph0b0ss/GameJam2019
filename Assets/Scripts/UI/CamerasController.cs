using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using Rewired;

public class CamerasController : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera _menuCamera;
    [SerializeField] private CinemachineVirtualCamera _gameCamera;

    public void ActivateMenuCamera(bool active)
    {
        if (active)
        {
            _menuCamera.Priority = 10;
            _gameCamera.Priority = 1;
        }
        else
        {
            _menuCamera.Priority = 1;
            _gameCamera.Priority = 10;
        }
    }
}
