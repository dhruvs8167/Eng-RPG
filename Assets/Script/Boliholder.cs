using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boliholder : MonoBehaviour
{
    public string[] dialogue;
    public Sprite[] CharacterImages;
    public int cc;

    private Bolimanager d;
    // Use this for initialization
    void Start()
    {
        d = FindObjectOfType<Bolimanager>();
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "yo")
        {
            //d.Showbox(dialogue);
            d.c = cc;
            d.bolilines = dialogue;
            d.CharacterImages = CharacterImages;
            d.currentline = 0;
            d.currentCharacter = 0;
            d.Showboli();
        }
    }
}
