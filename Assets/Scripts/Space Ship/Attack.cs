using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField] float fireRate = 0.5f;
    float currentFireRate;
    public GameObject CurrentFirerateGameObject;
    public GameObject AsteriodDestroyStreakGameObject;
    private float nextMovement;
    public GameObject plasmaProjectile;
    public float currentAsteriodDestroyStreak;
    // Start is called before the first frame update
    void ShipShoot() 
    {
        Instantiate(plasmaProjectile, new Vector2(gameObject.transform.position.x, -2.75f), Quaternion.identity);
        nextMovement = Time.time + currentFireRate;
    }
    void Start()
    {
        currentAsteriodDestroyStreak = 0;
        currentFireRate = fireRate;
        nextMovement = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        //Debuging Stuff
        CurrentFirerateGameObject.GetComponent<TextMeshPro>().

        //Debug.Log(currentFireRate);
        
        //Current Firerate
        currentFireRate = fireRate/Mathf.Pow(currentAsteriodDestroyStreak+1, 1f/3f);
        

        //Arrow Keys
        if (Input.GetKey(KeyCode.UpArrow) && nextMovement <= Time.time && PlayerPrefs.GetInt("Input Option") == 0)
        {
            ShipShoot();
            /*
            Instantiate(plasmaProjectile, new Vector2(gameObject.transform.position.x, -2.75f), Quaternion.identity);
            nextMovement = Time.time + fireRate;
            */
        } else if (PlayerPrefs.GetInt("Input Option") == 0 && !Input.GetKey(KeyCode.UpArrow)) 
        {
            currentAsteriodDestroyStreak = 0;
        }
        //AWSD Keys
        if (Input.GetKey(KeyCode.W) && nextMovement <= Time.time && PlayerPrefs.GetInt("Input Option") == 1)
        {
            ShipShoot();
            /*
            Instantiate(plasmaProjectile, new Vector2(gameObject.transform.position.x, -2.75f), Quaternion.identity);
            nextMovement = Time.time + fireRate;
            */
        } else if (PlayerPrefs.GetInt("Input Option") == 1 && !Input.GetKey(KeyCode.W)) 
        {
            currentAsteriodDestroyStreak = 0;
        }
        //Mouse
        if (Input.GetMouseButton(0) && nextMovement <= Time.time && PlayerPrefs.GetInt("Input Option") == 2)
        {
            ShipShoot();
            /*
            Instantiate(plasmaProjectile, new Vector2(gameObject.transform.position.x, -2.75f), Quaternion.identity);
            gameObject.GetComponent<AudioSource>().Play();
            nextMovement = Time.time + fireRate;
            */
        } else if (PlayerPrefs.GetInt("Input Option") == 2 && !Input.GetMouseButton(0)) 
        {
            currentAsteriodDestroyStreak = 0;
        }
        //Controller
        if (Input.GetAxis("Fire Controller") == 1 && nextMovement <= Time.time && PlayerPrefs.GetInt("Input Option") == 3)
        {
            ShipShoot();
            /*
            Instantiate(plasmaProjectile, new Vector2(gameObject.transform.position.x, -2.75f), Quaternion.identity);
            nextMovement = Time.time + fireRate;
            */
        } else if (PlayerPrefs.GetInt("Input Option") == 3 && Input.GetAxis("Fire Controller") != 1) 
        {
            currentAsteriodDestroyStreak = 0;
        }
    
    }
}
