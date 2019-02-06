using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;
public class Moveman : MonoBehaviour {
    float dirX, dirY;
    public float speedup = 50f;
    public float speedside = 5f;
    public string startpoint;

    private static Moveman instanceRef;
    // Use this for initialization
    void Start () {
        Scene scene = SceneManager.GetActiveScene();
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
        Scene scene = SceneManager.GetActiveScene();
        dirX = CrossPlatformInputManager.GetAxis("Horizontal") * speedup * Time.deltaTime;
        dirY = CrossPlatformInputManager.GetAxis("Vertical") * speedside * Time.deltaTime;

        transform.position = new Vector2(transform.position.x + dirX, transform.position.y + dirY);
        if (scene.name == "fight" || scene.name == "Maze")
        {
            Destroy(gameObject);
        }
    }
}
