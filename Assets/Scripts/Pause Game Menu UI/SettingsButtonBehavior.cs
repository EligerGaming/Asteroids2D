using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsButtonBehavior : MonoBehaviour
{
    void PauseGameScreenDeactivate()
    {
        PauseGameScreen = GameObject.Find("Pause Game Screen");
        PauseGameScreen.SetActive(false);
    }
    void SettingsScreenActivate()
    {
        //SettingsScreen = GameObject.Find("Settings Screen");
        SettingsScreen.SetActive(true);
    }
    void OnMouseDown()
    {
        SettingsScreenActivate();
        PauseGameScreenDeactivate();
    }
    public GameObject SettingsScreen;
    GameObject PauseGameScreen;
    // Start is called before the first frame update
    void Start()
    {
        SettingsScreen = GameObject.Find("Settings Screen");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
