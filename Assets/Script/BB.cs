using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;
public class BB : MonoBehaviour {
    public GameObject db;
    public GameObject ui;
    public GameObject ci;
    
    public string leveltoload;
    
    // Use this for initialization
    void Start()
    {
        Advertisement.Initialize("2707560");

    }

    public void Doo()
    {
        ui.SetActive(false);

        AD.c = 1;
        SceneManager.LoadScene("timepass", LoadSceneMode.Additive);
    }
    public void Boo()
    {
        ci.SetActive(true);
        
    }
    public void Coo()
    {
        ci.SetActive(false);
        db.SetActive(false);
    }
    public void Out()
    {
        if(Advertisement.IsReady())
        {
            Advertisement.Show();
        }
        SceneManager.LoadScene(leveltoload);
        
    }
    public void Gre()
    {
        ui.SetActive(true);
    }
    public void Quit()
    {
        
        Application.Quit();
    }
    public void Crid()
    {
        SceneManager.LoadScene("Cridets");
    }
}
