using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Angrydestroy : MonoBehaviour {
    public float health = 4f;
    public GameObject blood;
    
    void OnCollisionEnter2D(Collision2D colinfo)
    {
       // he = colinfo.relativeVelocity.magnitude + he;

        if (colinfo.relativeVelocity.magnitude > health)
        {
            if (gameObject.tag == "ang")
            {


                Instantiate(blood, transform.position, Quaternion.identity);
            }
            Die();
        }

    }
    void Die()
    {
        if (gameObject.tag == "rr")
        {
            Stonesummoner.c = 1;
        }
        Destroy(gameObject);
        
    }
}
