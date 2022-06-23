using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MovementInputButtonBehavior : MonoBehaviour
{
    string[] MovementOptions = new string[] {"Arrow Keys", "WASD", "Mouse", "Controller"};
    void OnMouseDown() 
    {
        PlayerPrefs.SetInt("Input Option", PlayerPrefs.GetInt("Input Option") + 1);
        gameObject.GetComponent<AudioSource>().Play();
        if (PlayerPrefs.GetInt("Input Option") > 3)
        {
            PlayerPrefs.SetInt("Input Option", 0);
        }
        gameObject.GetComponent<SpriteRenderer>().color = new Color (0.7f, 0.7f, 0.7f, 1);
        Debug.Log("Changing Color");
    }
    void OnMouseUp() 
    {
        gameObject.GetComponent<SpriteRenderer>().color = new Color (1f, 1f, 1f, 1);
    }
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("Input Option") == false)
        {
            PlayerPrefs.SetInt("Input Option", 0);
            PlayerPrefs.Save();
        }
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Find("Text 2").GetComponent<TextMeshPro>().text = MovementOptions[PlayerPrefs.GetInt("Input Option")];
        gameObject.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("Master Volume");
    }
}
