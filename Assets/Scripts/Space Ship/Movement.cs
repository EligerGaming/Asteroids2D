using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float spaceShipInitialPos = 0f;
    
    [Range (0.01f, 0.2f)] [SerializeField]  float spaceShipSpeed = 0.1f;
    [SerializeField] float spaceShipDisplacement = 0.1f;
    private float nextMovement;
    private const float leftBorder = -7f;
    private const float rightBorder = 7f;
    void Start()
    {
        nextMovement = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.LeftArrow) && Time.time >= nextMovement)
        {
            nextMovement = Time.time + spaceShipSpeed;
            transform.position = new Vector2(setLeftPos(transform.position.x), transform.position.y);
        }
        if (Input.GetKey(KeyCode.RightArrow) && Time.time >= nextMovement)
        {
            nextMovement = Time.time + spaceShipSpeed;
            transform.position = new Vector2(setRightPos(transform.position.x), transform.position.y);
        }      
    }

    private float setLeftPos(float currentPos) 
    {
        float newPos = currentPos - spaceShipDisplacement;
        if (newPos < leftBorder)
        {
            return leftBorder;
        }
        else
        {
            return newPos;
        }
    }

    private float setRightPos(float currentPos) 
    {
        float newPos = currentPos + spaceShipDisplacement;
        if (newPos > rightBorder)
        {
            return rightBorder;
        }
        else
        {
            return newPos;
        }
    }
}
