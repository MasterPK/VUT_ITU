using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DIff_slider_script : MonoBehaviour
{
    public Slider mySlider;
    public TextMeshProUGUI textt;
    // Start is called before the first frame update
    void Start()
    {
        mySlider.onValueChanged.AddListener(valueChange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void valueChange(float value)
    {
        if (value == 0)
        {
            textt.text = "Jednoduchá";
        }
        if (value == 1)
        {
            textt.text = "Střední";
        }
        if (value == 2)
        {
            textt.text = "Náročná";
        }
    }
}
