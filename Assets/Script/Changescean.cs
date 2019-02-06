
using UnityEngine;
using UnityEngine.SceneManagement;

public class Changescean : MonoBehaviour {
    public string leveltoload;
    public string exitpoint;
    private Moveman thePlayer;
    // Use this for initialization
    void Start () {
        thePlayer = FindObjectOfType<Moveman>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "yo")
        {
            
            SceneManager.LoadScene(leveltoload);
            thePlayer.startpoint = exitpoint;
            
        }
    }
}
