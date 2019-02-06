using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exitpoint : MonoBehaviour {
    private Moveman thePlayer;
    public string leveltoload;
    public string exitpoint;
    void Start()
    {
        thePlayer = FindObjectOfType<Moveman>();
    }
    public void Pout()
    {
        SceneManager.LoadScene(leveltoload);
        thePlayer.startpoint = exitpoint;
    }
}
