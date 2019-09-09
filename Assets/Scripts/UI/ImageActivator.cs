using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ImageActivator : MonoBehaviour
{
   [SerializeField] private Image _activeCharacterImage;

   private bool _active;
   public bool Active
   {
      get => _active;
      set
      {
         _active = value;
         _activeCharacterImage.gameObject.SetActive(value);
      }
   }
   
}
