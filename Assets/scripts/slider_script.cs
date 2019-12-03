using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class slider_script : MonoBehaviour
{
    public TextMeshProUGUI textt;
    public Slider mySlider;
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
        if (value == 0){
            textt.text = "Black";
        }
        if (value == 1)
        {
            textt.text = "White";
        }
    }
}
