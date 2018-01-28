﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterClass : MonoBehaviour
{
    //Amount of time it will take to send the letter (likely between 1 and 14 days)
    int resourcesNeeded;

    //Whether the player has selected the letter to be sent
    bool selected = false;

    //Whether the player has sent the letter (only changed at the end of the day)
    bool sent = false;

    //An array of sprites (both before and after being selected) that can be accesed by a key
    string[] spriteNames = new string[6] { "test0.png", "test1.png", "test2.png", "test3.png", "test4.png", "test5.png" };
    string[] spriteNamesSelected = new string[6] { "testS0.png", "testS1.png", "testS2.png", "testS3.png", "testS4.png", "testS5.png" };

    //The key of the sprite of the letter in the array
    int spriteKey;

    //The name of the sprite file that will be used
    string spriteFile;

    //Tells whether the letter is from a text file or an img. True if it's an image, false if it's a text file
    bool imgOrTxt;

    //An array of the names of the txt files holding the letters that can be accessed by a key
    string[] letterTextNames = new string[7] { "letter0.txt", "letter1.txt", "letter2.txt", "letter3.txt", "letter4.txt", "letter5.txt", "letter6.txt" };

    //An array of the names of the img files holding the letters that can be accessed by a key
    string[] letterImgNames = new string[7] { "letterI0.png", "letterI1.png", "letterI2.png", "letterI3.png", "letterI4.png", "letterI5.png", "letterI6.png" };

    //The key of the text of the letter in the array
    int letterKey;

    //The name of the text or image file that will be used
    string letterFile;

	//Use this for initialization
	void Start ()
    {
        
	}

    // Pass in the number of resources needed (rn), the key of the letter sprite (sk), the key of the letter (lk), and wheather the letter is from a txt file or an img (it)
    void initializeLetter(int rn, int sk, int lk, bool it)
    {
        resourcesNeeded = rn;
        spriteKey = sk;
        letterKey = lk;
        imgOrTxt = it;
        spriteFile = spriteNames[spriteKey];

        if (imgOrTxt == true)
        {
            letterFile = letterImgNames[letterKey];
        }
        else
        {
            letterFile = letterTextNames[letterKey];
        }
    }

    //When you select the letter, call this. 
    void selectLetter()
    {
        selected = !selected;
        if (selected == true)
        {
            spriteFile = spriteNamesSelected[spriteKey];
        }
        else
        {
            spriteFile = spriteNames[spriteKey];
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
