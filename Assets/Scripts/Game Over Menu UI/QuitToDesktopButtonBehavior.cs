using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class QuitToDesktopButtonBehavior : MonoBehaviour
{
    void OnMouseDown()
    {
        PlayerPrefs.Save();
        Application.Quit();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
