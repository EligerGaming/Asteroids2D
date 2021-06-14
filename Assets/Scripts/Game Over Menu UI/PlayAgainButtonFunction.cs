using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayAgainButtonFunction : MonoBehaviour
{
    void OnMouseDown() 
    {
        SceneManager.LoadScene("GamePlay");
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
