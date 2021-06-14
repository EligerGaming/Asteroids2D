using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPauseGameScreenScript : MonoBehaviour
{
    void PauseGameScreenDeactivate()
    {
        PauseGameScreen = GameObject.Find("Pause Game Screen");
        PauseGameScreen.SetActive(false);
    }
    void PauseGameScreenReactivate()
    {
        PauseGameScreen.SetActive(true);
    }
    GameObject PauseGameScreen;
    public GameObject Ship;
    bool IsGameOver;
    // Start is called before the first frame update
    void Start()
    {
        PauseGameScreenDeactivate();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && Ship.GetComponent<Health>().GameOverScreen.activeSelf == false && PauseGameScreen.activeSelf == false)
        {
            Time.timeScale = 0;
            PauseGameScreenReactivate();
        } else if (Input.GetKeyDown(KeyCode.Escape) && Ship.GetComponent<Health>().GameOverScreen.activeSelf == false && PauseGameScreen.activeSelf == true)
        {
            Time.timeScale = 1;
            PauseGameScreenDeactivate();
        }
        
        
        
    }
}
