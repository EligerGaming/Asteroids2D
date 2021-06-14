using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    void GameOverScreenDeactivate()
    {
        GameOverScreen = GameObject.Find("GameOverScreen");
        GameOverScreen.SetActive(false);
    }

    void GameOverScreenReactivate()
    {
        GameOverScreen.SetActive(true);
    }
    //public bool IsGameOverScreenActive;
    public GameObject GameOverScreen;
    GameObject ScoreObject;
    [SerializeField] float maxHealth = 3;
    [SerializeField] float damage = 1;
    [SerializeField] public float healthPoints;
    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.tag == "damageObject")
        {
            healthPoints -= damage;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
        GameOverScreenDeactivate();
        //GameOverScreen = GameObject.Find("GameOverScreen");
        ScoreObject = GameObject.Find("currentScore");
        healthPoints = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (GameOverScreen.activeSelf == false)
        {
            IsGameOverScreenActive = false;
        }
         if (GameOverScreen.activeSelf == true)
        {
            IsGameOverScreenActive = true;
        }
        */
        if (healthPoints < 0)
        {
            Debug.Log("Healthpoints is zero, destroying ship object.");
            Destroy(gameObject);
            GameOverScreen.GetComponentInChildren<HighScoreTextBehavior>().HighScore = PlayerPrefs.GetInt("High Score");
            GameOverScreenReactivate();
            //SceneManager.LoadScene("Start Menu");
            if (ScoreObject.GetComponent<Score>().currentScore > HighScore.getStoredHighScore())
            {
                PlayerPrefs.SetInt("High Score", (int)ScoreObject.GetComponent<Score>().currentScore);
            }

        }

        // For testing purposes only!
        if (Input.GetKeyUp(KeyCode.Delete))
        {
            healthPoints -= damage;
        }
        if (Input.GetKeyUp(KeyCode.Insert))
        {
            if (healthPoints < maxHealth) {
                healthPoints += damage;
            }
        }
    }
}
