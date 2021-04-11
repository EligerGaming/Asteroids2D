using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateHealth : MonoBehaviour
{
    public GameObject spaceShip;
    public SpriteRenderer spriteRenderer;

    public Sprite[] healthSprites;

    private int currentHealth = 0;
    
    void SetCurrentHealthSprite()
    {
        if (spaceShip != null)
        {   
            var shipHealth = spaceShip.GetComponent<Health>().healthPoints;
            if (shipHealth <= 0)
            {
                spriteRenderer.sprite = null;
                currentHealth = 0;
                return;
            }

            if (currentHealth != shipHealth)
            {
                // Need to update the UI with the new health.
                spriteRenderer.sprite = healthSprites[shipHealth - 1];
                currentHealth = shipHealth;
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        SetCurrentHealthSprite();
    }

    // Update is called once per frame
    void Update()
    {
        SetCurrentHealthSprite();
    }
}
