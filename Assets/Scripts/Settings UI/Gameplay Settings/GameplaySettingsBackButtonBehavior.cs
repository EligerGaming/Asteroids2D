using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplaySettingsBackButtonBehavior : MonoBehaviour
{
    public GameObject DifficultyButton;
    public GameObject MovementInputButton;
    public GameObject ResetHighScoreButton;
    public GameObject GameplayBackButton;
    public GameObject RootBackButton;
    public GameObject GameplaySettingsButton;
    public GameObject SoundSettingsButton;
    public GameObject DifficultyButtonText01;
    public GameObject DifficultyButtonText02;
    public GameObject MovementInputButtonText01;
    public GameObject MovementInputButtonText02;

    void ExitGameplaySettings()
    {
        
        DifficultyButton.GetComponent<SpriteRenderer>().enabled = false;
        DifficultyButton.GetComponent<DifficultyModeButtonBehavior>().enabled = false;
        DifficultyButton.GetComponent<BoxCollider2D>().enabled = false;
        MovementInputButton.GetComponent<SpriteRenderer>().enabled = false;
        MovementInputButton.GetComponent<MovementInputButtonBehavior>().enabled = false;
        MovementInputButton.GetComponent<BoxCollider2D>().enabled = false;
        MovementInputButtonText01.GetComponent<MeshRenderer>().enabled = false;
        MovementInputButtonText02.GetComponent<MeshRenderer>().enabled = false;
        ResetHighScoreButton.GetComponent<SpriteRenderer>().enabled = false;
        ResetHighScoreButton.GetComponent<BoxCollider2D>().enabled = false;
        ResetHighScoreButton.GetComponent<ResetHighScoreButtonBehavior>().enabled = false;
        ResetHighScoreButton.GetComponentInChildren<MeshRenderer>().enabled = false;
        DifficultyButtonText01.GetComponent<MeshRenderer>().enabled = false;
        DifficultyButtonText02.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        gameObject.GetComponent<GameplaySettingsBackButtonBehavior>().enabled = false;
        gameObject.GetComponentInChildren<MeshRenderer>().enabled = false;

        GameplaySettingsButton.GetComponent<SpriteRenderer>().enabled = true;
        GameplaySettingsButton.GetComponent<BoxCollider2D>().enabled = true;
        GameplaySettingsButton.GetComponent<GameplaySettingsButtonBehavior>().enabled = true;
        GameplaySettingsButton.GetComponentInChildren<MeshRenderer>().enabled = true;
        RootBackButton.GetComponent<SpriteRenderer>().enabled = true;
        RootBackButton.GetComponent<BoxCollider2D>().enabled = true;
        RootBackButton.GetComponent<RootSettingsBackButtonBehavior>().enabled = true;
        RootBackButton.GetComponentInChildren<MeshRenderer>().enabled = true;
        SoundSettingsButton.GetComponent<SpriteRenderer>().enabled = true;
        SoundSettingsButton.GetComponent<BoxCollider2D>().enabled = true;
        SoundSettingsButton.GetComponent<SoundSettingsButtonBehavior>().enabled = true;
        SoundSettingsButton.GetComponentInChildren<MeshRenderer>().enabled = true;
    }
   
    void OnMouseDown() 
    {
        gameObject.GetComponent<SpriteRenderer>().color = new Color (0.7f, 0.7f, 0.7f, 1);
        gameObject.GetComponent<AudioSource>().Play();
        Debug.Log("Changing Color");
    }
    void OnMouseUp() 
    {
        gameObject.GetComponent<SpriteRenderer>().color = new Color (1f, 1f, 1f, 1);
        ExitGameplaySettings();
    }
    // Start is called before the first frame update
    void Start()
    {
       ExitGameplaySettings();
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("Master Volume");
    }
}
