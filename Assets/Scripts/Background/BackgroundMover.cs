using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMover : MonoBehaviour
{
    //This is in Unity units per a second
    [SerializeField] public float backgroundMoveSpeed = 1;
    [SerializeField] public float moveTimeInterval = 0.05f;
    private float xPosition;
    private float yPosition;
    private float zPosition;
    private float timeStamp;
    // Start is called before the first frame update
    void Start()
    {
        timeStamp = 0;
    }

    // Update is called once per frame
    void Update()
    {
        xPosition = gameObject.GetComponent<Transform>().position.x;
        yPosition = gameObject.GetComponent<Transform>().position.y;
        zPosition = gameObject.GetComponent<Transform>().position.z; 
        timeStamp = timeStamp + Time.deltaTime;
        if (timeStamp >= moveTimeInterval)
        {
            gameObject.GetComponent<Transform>().position = new Vector3(xPosition, yPosition - (moveTimeInterval*backgroundMoveSpeed), zPosition);
            timeStamp = 0;
        }
        if (gameObject.GetComponent<Transform>().position.y <= -10.25)
        {
            gameObject.GetComponent<Transform>().position = new Vector3(xPosition, 10.25f, zPosition);
        }
    }
}
