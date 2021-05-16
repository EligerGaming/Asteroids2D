using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class HighScore : MonoBehaviour
{
    static public string HIGH_SCORE_KEY = "High Score";
    int Score;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey(HIGH_SCORE_KEY) == false) 
        {
            PlayerPrefs.SetInt(HIGH_SCORE_KEY, 0);
            PlayerPrefs.Save();
        }
    }

    // Update is called once per frame
    void Update()
    {
        Score = getStoredHighScore();
        gameObject.GetComponent<TextMeshPro>().text = Score.ToString();
    }

    static public int getStoredHighScore() {
        return PlayerPrefs.GetInt(HIGH_SCORE_KEY);
    }
}
