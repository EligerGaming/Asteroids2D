﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteriodPhysics : MonoBehaviour
{
    public GameObject spaceShipHurtAnimation;
    public GameObject AsteriodExplosion;
    public GameObject currentScore;
    public GameObject spaceShip;
    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.tag == "Player")
        {
            Destroy(gameObject);
            Instantiate(spaceShipHurtAnimation);
        }
        
        if (collider2D.tag == "playerProjectile")
        {
            Destroy(gameObject);
            currentScore.GetComponent<Score>().currentScore += 1;
            spaceShip.GetComponent<Attack>().currentAsteriodDestroyStreak += 1;
            Instantiate(AsteriodExplosion);
        }

    } 
    [SerializeField] float asteriodSpeed = 7f;
    // Start is called before the first frame update
    void Start()
    {
        spaceShip = GameObject.Find("Space Ship");
        currentScore = GameObject.Find("currentScore");
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, asteriodSpeed * -1);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -6)
        {
            Object.Destroy(gameObject);
        }
    }
}
