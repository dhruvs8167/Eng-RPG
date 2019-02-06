using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bolimanager : MonoBehaviour {
    public GameObject dBox;
    public GameObject db;
    public Text dText;
    public Image Character;
    public Sprite[] CharacterImages;
    public int currentCharacter;
    
    public string[] bolilines;
    public int currentline;
    public int c;
    public void Deactivate()
    {
        dBox.SetActive(false);

    }
    public void Next()
    {
        currentline++;
        currentCharacter++;
        if (currentline >= bolilines.Length)
        {
            
            
                dBox.SetActive(false);
                
                currentline = 0;
                currentCharacter = 0;
            if(c==1)
            {
                db.SetActive(true);
            }
            if(c==2)
            {
                SceneManager.LoadScene("Exp1");
            }
           
        }
        dText.text = bolilines[currentline];
        Character.sprite = CharacterImages[currentCharacter];
    }
    public void Showboli()
    {
        dBox.SetActive(true);
        dText.text = bolilines[0];
        Character.sprite = CharacterImages[0];
    }
}
    

