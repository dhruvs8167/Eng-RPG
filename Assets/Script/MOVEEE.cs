using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;
public class MOVEEE : MonoBehaviour {

    float dirX, dirY;
    public float speedup = 50f;
    public float speedside = 5f;
    public string startpoint;

   
    // Use this for initialization
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        
        dirX = CrossPlatformInputManager.GetAxis("Horizontal") * speedup * Time.deltaTime;
        dirY = CrossPlatformInputManager.GetAxis("Vertical") * speedside * Time.deltaTime;

        transform.position = new Vector2(transform.position.x + dirX, transform.position.y + dirY);
       
    }
}
