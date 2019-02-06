using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CAn : MonoBehaviour {
    public static int s;
    
    public GameObject ui;
    
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (s == 1)
        {
            
            ui.SetActive(true);
            s = 0;
        }
        
        
	}
}
