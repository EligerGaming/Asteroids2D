using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectVolume : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("Sound Effects Volume")*PlayerPrefs.GetFloat("Master Volume");
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("Sound Effects Volume")*PlayerPrefs.GetFloat("Master Volume");
    }
}
