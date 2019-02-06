using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outposition : MonoBehaviour {

    // Use this for initialization
    private Moveman thePlayer;
    private Cameraattach theCamera;
    public string pointname;
	void Start () {

     
            thePlayer = FindObjectOfType<Moveman>();
        if (thePlayer.startpoint == pointname)
        {
            thePlayer.transform.position = transform.position;

            theCamera = FindObjectOfType<Cameraattach>();
            theCamera.transform.position = new Vector3(transform.position.x, transform.position.y, theCamera.transform.position.z);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
