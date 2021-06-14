using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsBackButtonBehavior : MonoBehaviour
{
    void PauseGameScreenActivate()
    {
        PauseGameScreen = GameObject.Find("Pause Game Screen");
        PauseGameScreen.SetActive(true);
    }
    void SettingsScreenDeactivate()
    {
        SettingsScreen = GameObject.Find("Settings Screen");
        SettingsScreen.SetActive(false);
    }
    void OnMouseDown()
    {
        SettingsScreenDeactivate();
        PauseGameScreenActivate();
    }
    float currentTimeStamp;
    GameObject SettingsScreen;
    GameObject PauseGameScreen;
    // Start is called before the first frame update
    void Start()
    {
        currentTimeStamp = Time.time + 0.03f;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (currentTimeStamp <= Time.time)
        {
            SettingsScreenDeactivate();
        }
        
    }
}
