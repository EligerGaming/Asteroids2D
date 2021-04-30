using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteriodPhysics : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        Destroy(gameObject);
    } 
    [SerializeField] float asteriodSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
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
