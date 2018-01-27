using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterClass : MonoBehaviour
{
    //Amount of time it will take to send the letter (likely between 1 and 14 days)
    int resourcesNeeded;

    //A key pointing to a sprite name in an array of sprites (both before and after being selected)
    string[] spriteNames = new string[6] { "test0.png", "test1.png", "test2.png", "test3.png", "test4.png", "test5.png" };
    string[] spriteNamesSelected = new string[6] { "testS0.png", "testS1.png", "testS2.png", "testS3.png", "testS4.png", "testS5.png" };

    //The name of the sprite file that will be used
    string sprite;

    //The index of the sprite of the letter in the array
    int spriteKey;

    //Weather the player has selected the letter to be sent
    bool selected = false;

    //Weather the player has sent the letter (only changed at the end of the day)
    bool sent = false;

	// Use this for initialization
	void Start (int rn, int sk)
    {
        resourcesNeeded = rn;
        spriteKey = spriteKey;
        sprite = spriteNames[sk];
	}

    //When you select the letter, call this
    void selectLetter()
    {
        selected = !selected;
        if (selected = true)
        {
            sprite = spriteNamesSelected[spriteKey];
        }
        else
        {
            sprite = spriteNames[spriteKey];
        }
    }

    //At the end of the day, call this on all the letters
    void sendLetter()
    {
        sent = true;
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
