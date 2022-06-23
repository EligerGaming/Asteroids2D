using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
   // Start is called before the first frame update
    public GameObject GamePausedObject;
    private float lastShipPos;
    static float spaceShipY = -3.5f;
    [Range (1f, 10f)] [SerializeField]  float spaceShipSpeed = 10f;
    [SerializeField] private float leftBorder = -4f;
    [SerializeField] private float rightBorder = 4f;
    private Vector3 sceneMousePosition;
    private float currentDisplacement;
    private float lastMousePos = 0f;
    private float currentHorizontalVelocity 
    {
        get {
            return gameObject.GetComponent<Rigidbody2D>().velocity.x;
        }
    }
    void setCurrentPosition(float x)
    {
        gameObject.GetComponent<Transform>().position = new Vector2(x, spaceShipY);
    }
    // Gets the ship's current position.
    private float getCurrentPosition
    {
        get {
            return gameObject.transform.position.x;
        }
    }
    void setCurrentVelocity(float x, float y)
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(x, y);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GamePausedObject.activeSelf == false) 
        {
            lastShipPos = gameObject.GetComponent<Rigidbody2D>().position.x;
        }  
        currentDisplacement = spaceShipSpeed / Application.targetFrameRate;
        sceneMousePosition = Camera.main.ScreenToWorldPoint(new Vector3 (Input.mousePosition.x, Input.mousePosition.y));
        //Arrow Keys Movement
        if (PlayerPrefs.GetInt("Input Option") == 0)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow) && getCurrentPosition > leftBorder)
            {
                setCurrentVelocity(spaceShipSpeed * -1, 0);
            }
            if (Input.GetKeyDown(KeyCode.RightArrow) && getCurrentPosition < rightBorder)
            {
                setCurrentVelocity(spaceShipSpeed, 0);
            }   
            //Save Code:  || getCurrentPosition() >= rightBorder || getCurrentPosition() <= leftBorder
            if (((Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow)) && !Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow)))
            {
            setCurrentVelocity(0, 0);
            }
        }
        //AWSD Movement
        if (PlayerPrefs.GetInt("Input Option") == 1)
        {
            if (Input.GetKeyDown(KeyCode.A) && getCurrentPosition > leftBorder)
            {
                setCurrentVelocity(spaceShipSpeed * -1, 0);
            }
            if (Input.GetKeyDown(KeyCode.D) && getCurrentPosition < rightBorder)
            {
                setCurrentVelocity(spaceShipSpeed, 0);
            }   
            //Save Code:  || getCurrentPosition() >= rightBorder || getCurrentPosition() <= leftBorder
            if (((Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D)) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D)))
            {
            setCurrentVelocity(0, 0);
            }
        }
        //Mouse Movement
        if (PlayerPrefs.GetInt("Input Option") == 2)
        {
            if (sceneMousePosition.x != lastMousePos)
            {
                if (sceneMousePosition.x < getCurrentPosition && getCurrentPosition > leftBorder)
                {
                    setCurrentVelocity(spaceShipSpeed * -1, 0);
                }
                if (sceneMousePosition.x > getCurrentPosition && getCurrentPosition < rightBorder)
                {
                    setCurrentVelocity(spaceShipSpeed, 0);
                }
                lastMousePos = sceneMousePosition.x;
            } 
            if (sceneMousePosition.x + currentDisplacement > getCurrentPosition && sceneMousePosition.x - currentDisplacement < getCurrentPosition) {
                setCurrentPosition(sceneMousePosition.x);
                setCurrentVelocity(0, 0);
            }
        }
        //Controller Movement
        if (PlayerPrefs.GetInt("Input Option") == 3)
        {
            if (Input.GetAxis("Horizontal Controller") < -0.5 && getCurrentPosition > leftBorder)
            {
                setCurrentVelocity(spaceShipSpeed * -1, 0);
            }
            if (Input.GetAxis("Horizontal Controller") > 0.5 && getCurrentPosition < rightBorder)
            {
                setCurrentVelocity(spaceShipSpeed, 0);
            }   
            if (Input.GetAxis("Horizontal Controller") > -0.5 && Input.GetAxis("Horizontal Controller") < 0.5)
            {
                setCurrentVelocity(0, 0);
            }
        }
        //Keeps ship from going past desginated borders
        if (getCurrentPosition >= rightBorder && currentHorizontalVelocity > 0)
        {
            setCurrentVelocity(0, 0);
        }
        if (getCurrentPosition <= leftBorder && currentHorizontalVelocity < 0)
        {
            setCurrentVelocity(0, 0);
        }
        //Locks ship movment if game is paused
        if (GamePausedObject.activeSelf == true)
        {
            setCurrentPosition(lastShipPos);
        }
    }
}
