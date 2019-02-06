using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spwanner : MonoBehaviour
{

    public GameObject spawnob;

    float randX;
    Vector2 whereToSpwan;
    public float spwanRate1 = 2f;

    float nextspwan = 0.0f;
    

    // Use this for initialization

    // Update is called once per frame
    void Update()
    {

        if (spwanRate1 > 0.3f)
        {
            if (Time.time > 5)
            {
                if (Time.time > nextspwan)
                {

                    nextspwan = Time.time + spwanRate1;
                    randX = Random.Range(34f, 46f);
                    whereToSpwan = new Vector2(randX, transform.position.y);
                    Instantiate(spawnob, whereToSpwan, Quaternion.identity);
                    spwanRate1 = spwanRate1 - 0.1f;
                }
            }



        }
        else
            if (Time.time > nextspwan)
        {
            nextspwan = Time.time + 0.3f;
            randX = Random.Range(33f, 48f);
            whereToSpwan = new Vector2(randX, transform.position.y);
            Instantiate(spawnob, whereToSpwan, Quaternion.identity);
        }

    }
   
}