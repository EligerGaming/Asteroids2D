using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineSoundVolume : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("Engine Volume")*PlayerPrefs.GetFloat("Master Volume");
    }
}
