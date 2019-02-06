using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spamm : MonoBehaviour {
    public GameObject spawnObject;
    public GameObject spawnob;
    Vector2 whereToSpwan;
    float randX;
    public float maxTime = 5;
    public float minTime = 2;

    //current time
    private float time;

    //The time to spawn the objec
    private float spawnTime;

    void Start()
    {
        SetRandomTime();
        time = minTime;
    }

    void FixedUpdate()
    {

        //Counts up
        time += Time.deltaTime;

        //Check if its the right time to spawn the object
        if (time >= spawnTime)
        {
            SpawnObject();
            SetRandomTime();
        }

    }


    //Spawns the object and resets the time
    void SpawnObject()
    {
        time = 0;
        randX = Random.Range(1.8f, -4.2f);
        whereToSpwan = new Vector2(transform.position.x,randX);
        Instantiate(spawnob, whereToSpwan, Quaternion.identity);
    }

    //Sets the random time between minTime and maxTime
    void SetRandomTime()
    {
        spawnTime = Random.Range(minTime, maxTime);
    }

}

