using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiPlayerPortrait : MonoBehaviour
{
    [SerializeField] private ImageFillSetter _pushBar;

    public FloatValue _pushBarFill;

    private void Update()
    {
        _pushBar.FillAmount = _pushBarFill;
    }
}
