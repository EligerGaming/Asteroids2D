﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ResetHighScoreButtonBehavior : MonoBehaviour
{
    [SerializeField] float textPopUpTime = 0.5f;
    public GameObject Warning;
    public GameObject Successful;
    private float currentTimeStamp;
    void OnMouseExit()
    {
        Warning.SetActive(false);
    }
    void OnMouseOver()
    {
        Warning.SetActive(true);
    }
    void OnMouseDown() 
    {
        gameObject.GetComponent<SpriteRenderer>().color = new Color (0.7f, 0.7f, 0.7f, 1);
        gameObject.GetComponent<AudioSource>().Play();
        Debug.Log("Changing Color");
    }
    void OnMouseUp() 
    {
        Debug.Log("Deleting HighScore");
        gameObject.GetComponent<SpriteRenderer>().color = new Color (1f, 1f, 1f, 1);
        currentTimeStamp = Time.time + textPopUpTime;
        PlayerPrefs.SetInt(HighScore.HIGH_SCORE_KEY, 0);
        Successful.SetActive(true);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTimeStamp < Time.time)
        {
            Successful.SetActive(false);
        }
        gameObject.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("Master Volume");
    }
}
