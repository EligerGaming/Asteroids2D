using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSettingsBackButtonBehavior : MonoBehaviour
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

    public GameObject SoundSettingsButton;
    public GameObject RootSettingsBackButton;
    public GameObject GameplaySettingsButton;

    void ExitSoundSettings()
    {
        MasterVolumeSliderKnob.GetComponent<SpriteRenderer>().enabled = false;
        MasterVolumeSliderKnob.GetComponent<SliderKnobBehavior>().enabled = false;
        MasterVolumeSliderKnob.GetComponent<CircleCollider2D>().enabled = false;
        SoundEffectsVolumeSliderKnob.GetComponent<SpriteRenderer>().enabled = false;
        SoundEffectsVolumeSliderKnob.GetComponent<SliderKnobBehavior>().enabled = false;
        SoundEffectsVolumeSliderKnob.GetComponent<CircleCollider2D>().enabled = false;
        SoundEffectsVolumeText.GetComponent<MeshRenderer>().enabled = false;
        EngineVolumeSliderKnob.GetComponent<SpriteRenderer>().enabled = false;
        EngineVolumeSliderKnob.GetComponent<SliderKnobBehavior>().enabled = false;
        EngineVolumeSliderKnob.GetComponent<CircleCollider2D>().enabled = false;
        MasterVolumeText.GetComponent<MeshRenderer>().enabled = false;
        EngineVolumeText.GetComponent<MeshRenderer>().enabled = false;
        SoundControlPanel.GetComponent<SpriteRenderer>().enabled = false;
        MasterVolumeSliderBar.GetComponent<SpriteRenderer>().enabled = false;
        SoundEffectsVolumeSliderBar.GetComponent<SpriteRenderer>().enabled = false;
        EngineVolumeSliderBar.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<SoundSettingsBackButtonBehavior>().enabled = false;
        gameObject.GetComponent<PolygonCollider2D>().enabled = false;

        GameplaySettingsButton.GetComponent<SpriteRenderer>().enabled = true;
        GameplaySettingsButton.GetComponent<GameplaySettingsButtonBehavior>().enabled = true;
        GameplaySettingsButton.GetComponentInChildren<MeshRenderer>().enabled = true;
        GameplaySettingsButton.GetComponent<BoxCollider2D>().enabled = true;
        RootSettingsBackButton.GetComponent<SpriteRenderer>().enabled = true;
        RootSettingsBackButton.GetComponent<RootSettingsBackButtonBehavior>().enabled = true;
        RootSettingsBackButton.GetComponentInChildren<MeshRenderer>().enabled = true;
        RootSettingsBackButton.GetComponent<BoxCollider2D>().enabled = true;
        SoundSettingsButton.GetComponent<SpriteRenderer>().enabled = true;
        SoundSettingsButton.GetComponent<SoundSettingsButtonBehavior>().enabled = true;
        SoundSettingsButton.GetComponentInChildren<MeshRenderer>().enabled = true;
        SoundSettingsButton.GetComponent<BoxCollider2D>().enabled = true;
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
        ExitSoundSettings();
    }
    // Start is called before the first frame update
    void Start()
    {
        ExitSoundSettings();
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("Master Volume");
    }
}
