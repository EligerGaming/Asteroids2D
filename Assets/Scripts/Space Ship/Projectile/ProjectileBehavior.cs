using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    public GameObject spaceShip;
    private float TopBorder = 5.5f;
    [SerializeField] float projectileSpeed = 10f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "damageObject") 
        {
            Destroy(gameObject);
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
       spaceShip = GameObject.Find("Space Ship");
       gameObject.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("Sound Effects Volume")*PlayerPrefs.GetFloat("Master Volume");
       gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, projectileSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= TopBorder)
        {
            Destroy(gameObject);
            spaceShip.GetComponent<Attack>().currentAsteriodDestroyStreak = 0;
        }
    }
}
