using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {
    public GameObject ui;
    public GameObject pi;
    public GameObject ci;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "d")
        {
           ui.SetActive(true);
           Destroy(gameObject);
        }
        if (col.gameObject.tag == "yo")
        {
            pi.SetActive(true);
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "f")
        {
            ci.SetActive(true);
            Destroy(gameObject);
        }
    }
}
