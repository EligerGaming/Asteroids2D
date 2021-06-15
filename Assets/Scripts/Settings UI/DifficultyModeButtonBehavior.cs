using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DifficultyModeButtonBehavior : MonoBehaviour
{
    string[] DifficultyMode = new string[] {"Default", "Easy"};
    public GameObject DifficultyModeText;
    void OnMouseDown() {
        PlayerPrefs.SetInt("Current Difficulty", PlayerPrefs.GetInt("Current Difficulty") + 1);
        if (PlayerPrefs.GetInt("Current Difficulty") > 1)
        {
            PlayerPrefs.SetInt("Current Difficulty", 0);
        }
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
    }
}
