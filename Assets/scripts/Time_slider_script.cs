using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Time_slider_script : MonoBehaviour
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
            textt.text = "3 minutes";
        }
        if (value == 1)
        {
            textt.text = "5 minutes";
        }
        if (value == 2)
        {
            textt.text = "10 minutes";
        }
        if (value == 3)
        {
            textt.text = "15 minutes";
        }
        if (value == 4)
        {
            textt.text = "30 minutes";
        }
        if (value == 5)
        {
            textt.text = "infinite";
        }
    }
}
