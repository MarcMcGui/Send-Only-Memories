﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LetterClass : MonoBehaviour {
    public GameManager gm;
    public Sprite[] sprites;
    public System.String[] texts;

    //Amount of time it will take to send the letter (likely between 1 and 14 days)
    int resourcesNeeded;

    //Whether the player has selected the letter to be sent
    bool selected = false;

    //Whether the player has sent the letter (only changed at the end of the day)
    bool sent = false;

    //Tells whether the letter is from a text file or an img. True if it's an image, false if it's a text file
    bool imgOrTxt;

    //Use this for initialization
    void Start() {
        gm = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update() {

    }

    //Change sprite when pin is clicked
    void chageSprite(int indexPosition) {
        GetComponent<SpriteRenderer>().sprite = sprites[gm.getIndex()];
        GetComponent<Text>().text = texts[gm.getIndex()];
    }

}