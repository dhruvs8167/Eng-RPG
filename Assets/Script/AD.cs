using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AD : MonoBehaviour {
    public static int c;
    public GameObject bi;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (c == 1)
        {
            bi.SetActive(false);
            c = 0;
        }

        if (c == 2)
        {
            bi.SetActive(true);
            c = 0;
        }
    }
}
