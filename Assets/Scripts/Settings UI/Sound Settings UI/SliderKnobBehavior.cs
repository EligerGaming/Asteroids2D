using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderKnobBehavior : MonoBehaviour
{
    bool SliderBeingChanged = false;
    void OnMouseDown()
    {
        SliderBeingChanged = true;
    }
    void OnMouseUp()
    {
        SliderBeingChanged = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SliderBeingChanged)
        {
            gameObject.GetComponent<Transform>().position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, gameObject.GetComponent<Transform>().position.y);          
        }
        if (gameObject.GetComponent<Transform>().position.x < -2.2f)
        {
            gameObject.GetComponent<Transform>().position = new Vector3(-2.2f, gameObject.GetComponent<Transform>().position.y);
        }
        if (gameObject.GetComponent<Transform>().position.x > 2.2f)
        {
            gameObject.GetComponent<Transform>().position = new Vector3(2.2f, gameObject.GetComponent<Transform>().position.y);
        }
                
    }
}
