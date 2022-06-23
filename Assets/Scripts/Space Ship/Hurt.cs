using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurt : MonoBehaviour
{
    private float timeStamp;
    [SerializeField] public float hurtAnimationLength = 1;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("Master Volume")*PlayerPrefs.GetFloat("Sound Effects Volume");
        gameObject.GetComponent<AudioSource>().Play();
        timeStamp = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - timeStamp >= hurtAnimationLength)
        {
            Destroy(gameObject);
        }
    }
}
