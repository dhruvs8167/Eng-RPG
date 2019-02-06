using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distroy : MonoBehaviour
{
    public float interval;
    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, interval);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "f")
        {

            Destroy(col.collider.gameObject);

        }
    }
}
