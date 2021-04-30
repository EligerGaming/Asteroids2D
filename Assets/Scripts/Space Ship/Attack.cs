using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField] float fireRate = 0.5f;
    private float nextMovement;
    public GameObject plasmaProjectile;
    // Start is called before the first frame update
    void Start()
    {
        nextMovement = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && nextMovement <= Time.time)
        {
            Instantiate(plasmaProjectile, new Vector2(gameObject.transform.position.x, -2.75f), Quaternion.identity);
            nextMovement = Time.time + fireRate;
        }
    }
}
