using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Start_game : MonoBehaviour
{
    public Button tlacitko;
    // Start is called before the first frame update
    void Start()
    {
        try
        {
            tlacitko.onClick.AddListener(TaskOnClick);
        }catch
        { }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void TaskOnClick()
    {
        SceneManager.LoadScene(1);
    }

    public void OpenTutorial()
    {
        SceneManager.LoadScene(2);
    }

    public void CloseTutorial()
    {
        SceneManager.LoadScene(0);
    }
}
