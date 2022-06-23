using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplaySettingsButtonBehavior : MonoBehaviour
{
    public GameObject DifficultyButton;
    public GameObject MovementInputButton;
    public GameObject ResetHighScoreButton;
    public GameObject GameplayBackButton;
    public GameObject RootBackButton;
    public GameObject SoundSettingsButton;
    public GameObject DifficultyButtonText01;
    public GameObject DifficultyButtonText02;
    public GameObject MovementInputButtonText01;
    public GameObject MovementInputButtonText02;
    //bool privateShouldBeInGameplaySettings;
    
    void EnterGameplaySettings()
    {
        
        DifficultyButton.GetComponent<SpriteRenderer>().enabled = true;
        DifficultyButton.GetComponent<DifficultyModeButtonBehavior>().enabled = true;
        DifficultyButton.GetComponentInChildren<MeshRenderer>().enabled = true;
        DifficultyButton.GetComponent<BoxCollider2D>().enabled = true;
        MovementInputButtonText01.GetComponent<MeshRenderer>().enabled = true;
        MovementInputButtonText02.GetComponent<MeshRenderer>().enabled = true;
        MovementInputButton.GetComponent<SpriteRenderer>().enabled = true;
        MovementInputButton.GetComponent<MovementInputButtonBehavior>().enabled = true;
        MovementInputButton.GetComponentInChildren<MeshRenderer>().enabled = true;
        MovementInputButton.GetComponent<BoxCollider2D>().enabled = true;
        DifficultyButtonText01.GetComponent<MeshRenderer>().enabled = true;
        DifficultyButtonText02.GetComponent<MeshRenderer>().enabled = true;
        ResetHighScoreButton.GetComponent<SpriteRenderer>().enabled = true;
        ResetHighScoreButton.GetComponent<ResetHighScoreButtonBehavior>().enabled = true;
        ResetHighScoreButton.GetComponentInChildren<MeshRenderer>().enabled = true;
        ResetHighScoreButton.GetComponent<BoxCollider2D>().enabled = true;
        GameplayBackButton.GetComponent<SpriteRenderer>().enabled = true;
        GameplayBackButton.GetComponent<GameplaySettingsBackButtonBehavior>().enabled = true;
        GameplayBackButton.GetComponentInChildren<MeshRenderer>().enabled = true;
        GameplayBackButton.GetComponent<BoxCollider2D>().enabled = true;
        
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<GameplaySettingsButtonBehavior>().enabled = false;
        gameObject.GetComponentInChildren<MeshRenderer>().enabled = false;
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        RootBackButton.GetComponent<SpriteRenderer>().enabled = false;
        RootBackButton.GetComponent<RootSettingsBackButtonBehavior>().enabled = false;
        RootBackButton.GetComponentInChildren<MeshRenderer>().enabled = false;
        RootBackButton.GetComponent<BoxCollider2D>().enabled = false;
        SoundSettingsButton.GetComponent<SpriteRenderer>().enabled = false;
        SoundSettingsButton.GetComponent<SoundSettingsButtonBehavior>().enabled = false;
        SoundSettingsButton.GetComponentInChildren<MeshRenderer>().enabled = false;
        SoundSettingsButton.GetComponent<BoxCollider2D>().enabled = false;
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
        EnterGameplaySettings();
    }
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
