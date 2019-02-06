using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Cameraattach : MonoBehaviour {
    public Transform target;
    public float smothspeed = 1.25f;
    public Vector3 offset;
    // Use this for initialization
    
    private static Cameraattach instanceRef;
    
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
    void LateUpdate()
    {
        transform.position = target.position + offset;  
    }
    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "fight" )
        {
            Destroy(gameObject);
        }
    }
}
