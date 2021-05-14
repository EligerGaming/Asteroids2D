using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Health : MonoBehaviour
{
    
    
    [SerializeField] float maxHealth = 3;
    [SerializeField] float damage = 1;
    [SerializeField] public float healthPoints;
    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.tag == "damageObject")
        {
            healthPoints -= damage;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        healthPoints = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (healthPoints < 0)
        {
            Debug.Log("Healthpoints is zero, destroying ship object.");
            Destroy(gameObject);
            SceneManager.LoadScene("Start Menu");
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
