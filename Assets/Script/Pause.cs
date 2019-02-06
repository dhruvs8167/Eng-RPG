using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {
    private static Pause instanceRef;
    public static int c;
    // Use this for initialization
    void Start () {
        if (instanceRef == null)
        {
            instanceRef = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            DestroyImmediate(gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
        Quitgame.b = c;
	}
}
