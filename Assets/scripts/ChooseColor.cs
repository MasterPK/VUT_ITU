using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseColor : MonoBehaviour
{
    public Image whiteImg;
   public void SetImage(Image image)
    {
        whiteImg.sprite = Resources.Load<Sprite>("black");

    }

  
}
