using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
    private float TopBorder = 5.5f;
    [Range (0.01f, 0.2f)] [SerializeField]  float projectileSpeed = 0.1f;
    [SerializeField] float projectileDisplacement = 0.1f;
    private float nextMovement;
    // Start is called before the first frame update
    void Start()
    {
        nextMovement = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextMovement)
        {
            nextMovement = Time.time + projectileSpeed;
            transform.position = new Vector2(transform.position.x, transform.position.y + projectileDisplacement);
        }

        if (transform.position.y >= TopBorder)
        {
            Destroy(gameObject);
        }
    
    }
}
