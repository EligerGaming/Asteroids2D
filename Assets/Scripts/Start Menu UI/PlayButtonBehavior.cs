using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtonBehavior : MonoBehaviour
{
    void OnMouseDown() 
    {
        gameObject.GetComponent<SpriteRenderer>().color = new Color (0.7f, 0.7f, 0.7f, 1);
        gameObject.GetComponent<AudioSource>().Play();
        Debug.Log("Changing Color");
    }
    void OnMouseUp() 
    {
        SceneManager.LoadScene("GamePlay");
        Debug.Log("Switching Scene");
        gameObject.GetComponent<SpriteRenderer>().color = new Color (1f, 1f, 1f, 1);
    }
    
    public void onClick() 
    {
        //SceneManager.LoadScene("GamePlay");
        //Debug.Log("Switching Scene");
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
