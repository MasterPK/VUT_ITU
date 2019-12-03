using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseColor : MonoBehaviour
{
    public Image whiteImg;
    public Image whiteImgFrame;
    public Image blackImg;
    public Image blackImgFrame;
    public void SetActiveWhite()
    {
        whiteImgFrame.enabled = true;
        blackImgFrame.enabled = false;
    }

    public void SetActiveBlack()
    {
        whiteImgFrame.enabled = false;
        blackImgFrame.enabled = true;
    }


}
