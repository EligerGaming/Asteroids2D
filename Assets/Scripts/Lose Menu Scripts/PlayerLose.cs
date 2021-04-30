using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLose : MonoBehaviour
{
    public GameObject spaceShip;
    int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        spaceShip.GetComponent<Health>().healthPoints = currentHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth == 0)
        {
            
        }
    }
}
