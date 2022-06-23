using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class DifficultyModeButtonBehavior : MonoBehaviour
{
    string[] DifficultyMode = new string[] {"Default", "Easy"};
    public GameObject DifficultyModeText;
    void OnMouseDown() 
    {
        PlayerPrefs.SetInt("Current Difficulty", PlayerPrefs.GetInt("Current Difficulty") + 1);
        gameObject.GetComponent<AudioSource>().Play();
        if (PlayerPrefs.GetInt("Current Difficulty") > 1)
        {
            PlayerPrefs.SetInt("Current Difficulty", 0);
        }
        gameObject.GetComponent<SpriteRenderer>().color = new Color (0.7f, 0.7f, 0.7f, 1);
        Debug.Log("Changing Color");
    }
    void OnMouseUp() 
    {
        gameObject.GetComponent<SpriteRenderer>().color = new Color (1f, 1f, 1f, 1);
    }
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("Current Difficulty") == false)
        {
            PlayerPrefs.SetInt("Current Difficulty", 0);
            PlayerPrefs.Save();
        }
    }

    // Update is called once per frame
    void Update()
    {
        DifficultyModeText.GetComponent<TextMeshPro>().text = DifficultyMode[PlayerPrefs.GetInt("Current Difficulty")];
        gameObject.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("Master Volume");
    }
}
