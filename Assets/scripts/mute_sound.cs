using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class mute_sound : MonoBehaviour
{
    public TextMeshProUGUI txt;
    public Button tlacitko;
    public AudioSource zvuk;
    // Start is called before the first frame update
    void Start()
    {
        tlacitko.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void TaskOnClick()
    {
        if (zvuk.isPlaying)
        {
            zvuk.Stop();
        }
        else
        {
            zvuk.Play();
        }
    }
}
