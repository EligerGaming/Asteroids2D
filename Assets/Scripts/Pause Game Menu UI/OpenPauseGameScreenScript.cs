using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPauseGameScreenScript : MonoBehaviour
{
    void PauseGameScreenDeactivate()
    {
        PauseGameScreen = GameObject.Find("Pause Game Screen");
        PauseGameScreen.SetActive(false);
        //GamePaused = false;
    }
    void PauseGameScreenReactivate()
    {
        PauseGameScreen.SetActive(true);
        //GamePaused = true;
    }
    GameObject PauseGameScreen;
    //private bool GamePaused;
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
        /*
        if (GamePaused == true)
        {
            Ship.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
        */
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
