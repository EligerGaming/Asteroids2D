using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeButtonBehavior : MonoBehaviour
{
    void PauseGameScreenDeactivate()
    {
        PauseGameScreen = GameObject.Find("Pause Game Screen");
        PauseGameScreen.SetActive(false);
    }
    void OnMouseDown() 
    {
        Time.timeScale = 1;
        PauseGameScreenDeactivate();
    }
    GameObject PauseGameScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
