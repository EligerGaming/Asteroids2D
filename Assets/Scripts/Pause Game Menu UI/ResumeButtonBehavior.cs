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
        gameObject.GetComponent<SpriteRenderer>().color = new Color (0.7f, 0.7f, 0.7f, 1);
        gameObject.GetComponent<AudioSource>().Play();
        Debug.Log("Changing Color");
    }
    void OnMouseUp() 
    {
        Time.timeScale = 1;
        PauseGameScreenDeactivate();
        gameObject.GetComponent<SpriteRenderer>().color = new Color (1f, 1f, 1f, 1);
    }
    GameObject PauseGameScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("Master Volume");
    }
}
