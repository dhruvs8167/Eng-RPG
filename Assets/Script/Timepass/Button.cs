using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Button : MonoBehaviour {
    
	public void Reload()
    {
        SceneManager.UnloadSceneAsync("timepass");
        SceneManager.LoadScene("timepass", LoadSceneMode.Additive);
    }
    public void End()
    {
        CAn.s = 1;
        AD.c = 2;
        SceneManager.UnloadSceneAsync("timepass");
    }
}
