using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class DisplayScore : MonoBehaviour
{
    public GameObject currentScoreGameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<TextMeshPro>().text = currentScoreGameObject.GetComponent<Score>().currentScore.ToString();
    }
}
