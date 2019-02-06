using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;
public class Quitgame : MonoBehaviour {
    public GameObject ui;
    public GameObject bi;
    public static int b;
    void Start()
    {
        Advertisement.Initialize("2707560");

    }
    public void Oui()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
        ui.SetActive(true);
    }
    public void Cui()
    {

        
        ui.SetActive(false);
    }
    public void Quit()
    {
        
        Application.Quit();
    }
    public void Voice()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
        bi.SetActive(false);       
    }
    public void Unmute()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
        bi.SetActive(true);
    }
    public void Back()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
        SceneManager.LoadScene("Main Menu");
    }
    public void Loadrome()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
        SceneManager.LoadScene("room2");
    }
    void Update()
    {
        if (b == 1)
        {
            bi.SetActive(false);
        }
        if (b==0)
        {
            bi.SetActive(true);
        }
    }
}
