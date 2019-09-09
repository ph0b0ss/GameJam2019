using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageFillSetter : MonoBehaviour
{
   [SerializeField] private Image _image;

   public float FillAmount;

   private void Awake()
   {
      _image = GetComponent<Image>();
   }

   private void Update()
   {
      _image.fillAmount = FillAmount;
   }
}
