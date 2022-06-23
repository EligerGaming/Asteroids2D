using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineVolumeSettings : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("Engine Volume") == false)
        {
            PlayerPrefs.SetFloat("Engine Volume", 0.5f);
            PlayerPrefs.Save();
        }
        gameObject.GetComponent<Transform>().position = new Vector3((PlayerPrefs.GetFloat("Engine Volume")*(4.4f))-2.2f, gameObject.GetComponent<Transform>().position.y, gameObject.GetComponent<Transform>().position.z);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("Engine Volume", (gameObject.GetComponent<Transform>().position.x+2.2f)/4.4f);
        PlayerPrefs.Save();
        //Debug.Log(PlayerPrefs.GetFloat("Engine Volume"));
    }
}
