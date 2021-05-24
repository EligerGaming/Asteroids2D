using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MovementInputButtonBehavior : MonoBehaviour
{
    string[] MovementOptions = new string[] {"Arrow Keys", "WASD", "Mouse", "Controller"};
    void OnMouseDown() {
        PlayerPrefs.SetInt("Input Option", PlayerPrefs.GetInt("Input Option") + 1);
        if (PlayerPrefs.GetInt("Input Option") > 3)
        {
            PlayerPrefs.SetInt("Input Option", 0);
        }
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
    }
}
