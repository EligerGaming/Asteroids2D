using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float spaceShipInitialPos = 0f;
    [Range (1f, 10f)] [SerializeField]  float spaceShipSpeed = 10f;
    [SerializeField] private float leftBorder = -4f;
    [SerializeField] private float rightBorder = 4f;
    
    float currentVelocity()
    {
        return gameObject.GetComponent<Rigidbody2D>().velocity.x;
    }
    void currentVelocity(float x, float y)
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(x, y);
    }
    float currentPosition()
    {
        return gameObject.transform.position.x;
    }
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && currentPosition() > leftBorder)
        {
            currentVelocity(spaceShipSpeed * -1, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && currentPosition() < rightBorder)
        {
            currentVelocity(spaceShipSpeed, 0);
        }   
        //Save Code:  || currentPosition() >= rightBorder || currentPosition() <= leftBorder
        if (((Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow)) && !Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow)))
        {
            currentVelocity(0, 0);
        }
        if (currentPosition() >= rightBorder && currentVelocity() > 0)
        {
            currentVelocity(0, 0);
        }
        if (currentPosition() <= leftBorder && currentVelocity() < 0)
        {
            currentVelocity(0, 0);
        }
    }
}
