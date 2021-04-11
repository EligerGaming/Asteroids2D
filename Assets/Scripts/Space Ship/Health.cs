using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private static int maxHealth = 3;
    [SerializeField] int damage = 1;
    [SerializeField] public int healthPoints = maxHealth;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        healthPoints -= damage;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (healthPoints < 0)
        {
            Debug.Log("Healthpoints is zero, destroying ship object.");
            Destroy(gameObject);
        }

        // For testing purposes only!
        if (Input.GetKeyUp(KeyCode.Delete))
        {
            healthPoints -= damage;
        }
        if (Input.GetKeyUp(KeyCode.Insert))
        {
            if (healthPoints < maxHealth) {
                healthPoints += damage;
            }
        }
    }
}
