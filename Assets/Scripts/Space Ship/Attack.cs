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
        //Arrow Keys
        if (Input.GetKey(KeyCode.UpArrow) && nextMovement <= Time.time && PlayerPrefs.GetInt("Input Option") == 0)
        {
            Instantiate(plasmaProjectile, new Vector2(gameObject.transform.position.x, -2.75f), Quaternion.identity);
            nextMovement = Time.time + fireRate;
        }
        //AWSD Keys
        if (Input.GetKey(KeyCode.W) && nextMovement <= Time.time && PlayerPrefs.GetInt("Input Option") == 1)
        {
            Instantiate(plasmaProjectile, new Vector2(gameObject.transform.position.x, -2.75f), Quaternion.identity);
            nextMovement = Time.time + fireRate;
        }
        //Mouse
        if (Input.GetMouseButton(0) && nextMovement <= Time.time && PlayerPrefs.GetInt("Input Option") == 2)
        {
            Instantiate(plasmaProjectile, new Vector2(gameObject.transform.position.x, -2.75f), Quaternion.identity);
            nextMovement = Time.time + fireRate;
        }
        //Controller
        if (Input.GetAxis("Fire Controller") == 1 && nextMovement <= Time.time && PlayerPrefs.GetInt("Input Option") == 3)
        {
            Instantiate(plasmaProjectile, new Vector2(gameObject.transform.position.x, -2.75f), Quaternion.identity);
            nextMovement = Time.time + fireRate;
        }
    }
}
