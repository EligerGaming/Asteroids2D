using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class HighScoreTextBehavior : MonoBehaviour
{
    private float currentTimeStamp;
    private int currentColorSelection;
    [SerializeField] public float switchColorDelay = 1;
    private Color32 orangeColor = new Color32 (255, 140, 0, 255);
    private Color32 lightBlueColor = new Color32 (0, 170, 250, 255);
    private Color32 darkBlueColor = new Color32 (0, 25, 255, 255);
    private Color32 redColor = new Color32 (255, 0, 0, 255);
    private Color32 pinkColor = new Color32 (255, 0, 235, 255);
    private Color32 yellowColor = new Color32 (255, 255, 0, 255);
    private Color32 greenColor = new Color32 (0, 255, 0, 255);
    private Color32[] colorList;
    public int HighScore;
    public GameObject currentScoreGameObject;
    void switchColor()
    {
        currentColorSelection += 1;
    }
    // Start is called before the first frame update
    void Start()
    {
        currentTimeStamp = Time.time;
        colorList = new Color32[] {orangeColor, lightBlueColor, redColor, pinkColor, darkBlueColor, greenColor, yellowColor};
        currentColorSelection = 0;
        currentTimeStamp = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentScoreGameObject.GetComponent<Score>().currentScore > HighScore && PlayerPrefs.GetInt("Current Difficulty") == 0)
        {
            gameObject.GetComponentInChildren<TextMeshPro>().text = "New High Score!";
            if (currentTimeStamp <= Time.time) 
            {
                currentTimeStamp = Time.time + switchColorDelay;
                currentColorSelection += 1;
                if (currentColorSelection >= colorList.Length)
                {
                    currentColorSelection = 0;
                }
            }
            gameObject.GetComponentInChildren<TextMeshPro>().color = colorList[currentColorSelection];
        } else 
        {
            gameObject.GetComponentInChildren<TextMeshPro>().text = "Current High Score: " + PlayerPrefs.GetInt("High Score");
            gameObject.GetComponentInChildren<TextMeshPro>().color = new Color32 (255, 255, 255, 255);
        }
    }
}
