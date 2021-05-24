using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPlayerPrefsScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("Input Option") == false)
        {
            PlayerPrefs.SetInt("Input Option", 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
