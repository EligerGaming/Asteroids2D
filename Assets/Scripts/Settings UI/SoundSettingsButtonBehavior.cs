using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSettingsButtonBehavior : MonoBehaviour
{
    public GameObject MasterVolumeSliderKnob;
    public GameObject SoundControlPanel;
    public GameObject MasterVolumeSliderBar;
    public GameObject SoundEffectsVolumeSliderKnob;
    public GameObject SoundEffectsVolumeSliderBar;
    public GameObject MasterVolumeText;
    public GameObject SoundEffectsVolumeText;
    public GameObject EngineVolumeSliderKnob;
    public GameObject EngineVolumeSliderBar;
    public GameObject EngineVolumeText;
    public GameObject SoundSettingsBackButton;
    
    public GameObject RootSettingsBackButton;
    public GameObject GameplaySettingsButton;

    void EnterSoundSettings()
    {
        MasterVolumeSliderKnob.GetComponent<SpriteRenderer>().enabled = true;
        MasterVolumeSliderKnob.GetComponent<SliderKnobBehavior>().enabled = true;
        MasterVolumeSliderKnob.GetComponent<CircleCollider2D>().enabled = true;
        SoundEffectsVolumeSliderKnob.GetComponent<SpriteRenderer>().enabled = true;
        SoundEffectsVolumeSliderKnob.GetComponent<SliderKnobBehavior>().enabled = true;
        SoundEffectsVolumeSliderKnob.GetComponent<CircleCollider2D>().enabled = true;
        SoundEffectsVolumeText.GetComponent<MeshRenderer>().enabled = true;
        EngineVolumeSliderKnob.GetComponent<SpriteRenderer>().enabled = true;
        EngineVolumeSliderKnob.GetComponent<SliderKnobBehavior>().enabled = true;
        EngineVolumeSliderKnob.GetComponent<CircleCollider2D>().enabled = true;
        MasterVolumeText.GetComponent<MeshRenderer>().enabled = true;
        EngineVolumeText.GetComponent<MeshRenderer>().enabled = true;
        SoundControlPanel.GetComponent<SpriteRenderer>().enabled = true;
        MasterVolumeSliderBar.GetComponent<SpriteRenderer>().enabled = true;
        SoundEffectsVolumeSliderBar.GetComponent<SpriteRenderer>().enabled = true;
        EngineVolumeSliderBar.GetComponent<SpriteRenderer>().enabled = true;
        SoundSettingsBackButton.GetComponent<SpriteRenderer>().enabled = true;
        SoundSettingsBackButton.GetComponent<SoundSettingsBackButtonBehavior>().enabled = true;
        SoundSettingsBackButton.GetComponent<PolygonCollider2D>().enabled = true;

        GameplaySettingsButton.GetComponent<SpriteRenderer>().enabled = false;
        GameplaySettingsButton.GetComponent<GameplaySettingsButtonBehavior>().enabled = false;
        GameplaySettingsButton.GetComponentInChildren<MeshRenderer>().enabled = false;
        GameplaySettingsButton.GetComponent<BoxCollider2D>().enabled = false;
        RootSettingsBackButton.GetComponent<SpriteRenderer>().enabled = false;
        RootSettingsBackButton.GetComponent<RootSettingsBackButtonBehavior>().enabled = false;
        RootSettingsBackButton.GetComponentInChildren<MeshRenderer>().enabled = false;
        RootSettingsBackButton.GetComponent<BoxCollider2D>().enabled = false;
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<SoundSettingsButtonBehavior>().enabled = false;
        gameObject.GetComponentInChildren<MeshRenderer>().enabled = false;
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
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
        EnterSoundSettings();
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
