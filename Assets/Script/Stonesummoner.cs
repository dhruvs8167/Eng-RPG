using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;
public class Stonesummoner : MonoBehaviour {
    
    public GameObject spawnob;
    Vector2 whereToSpwan;
    float randX;
    public static int c;
    public string newsceen;
    // Use this for initialization
    void Start () {
        Advertisement.Initialize("2707560");

    }
	
	// Update is called once per frame
	void Update () {
		if(c==1)
        {
            randX = Random.Range(-6.20f, -6.21f);
            whereToSpwan = new Vector2(randX, transform.position.y);
            Instantiate(spawnob, whereToSpwan, Quaternion.identity);
            c =0;
        }

        if (GameObject.FindWithTag("ang") == null)
        {
            if (Advertisement.IsReady())
            {
                Advertisement.Show();
            }
            SceneManager.LoadScene(newsceen);
            
        }

    }
}
