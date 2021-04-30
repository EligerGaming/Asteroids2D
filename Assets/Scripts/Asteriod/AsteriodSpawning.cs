using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteriodSpawning : MonoBehaviour
{
    [SerializeField] float leftBorder = -4f;
    [SerializeField] float rightBorder = 4f;
    [SerializeField] float asteriodSpawningRate = 0.5f;
    float randomNumGen;
    float nextInstantiate;
    public GameObject asteriod;
    // Start is called before the first frame update
    void Start()
    {
        float nextInstantiate = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (nextInstantiate <= Time.time) 
        {
            randomNumGen = Mathf.Round(Random.Range(leftBorder * 10, rightBorder * 10)) / 10;
            Instantiate(asteriod, new Vector2(randomNumGen, 5), Quaternion.identity);
            nextInstantiate = Time.time + asteriodSpawningRate;
        }
        
    }
}
