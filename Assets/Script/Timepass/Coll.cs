using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Coll : MonoBehaviour {
    public GameObject ui;
    void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.tag == "f")
        {

            ui.SetActive(true);
            Destroy(col.collider.gameObject);
        }
    }
   
}
