﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour {

    //should determine what menu opens
    public int location;
    public GameManager gm;

    public LetterMenu let;
    public Sprite normal;
    public Sprite highlighted;
    public SpriteRenderer spr;

    // Use this for initialization
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        let = FindObjectOfType<LetterMenu>();
        Debug.Log("Game started");
        spr = GetComponent<SpriteRenderer>();
        spr.sprite = normal;
    }

    //highlights sprite when mouse over pin,
    //opens menu when clicked
    private void OnMouseOver() {
        Debug.Log("Mouse over pin");
        spr.sprite = highlighted;
    }

    //mouse goes to normal sprite when leaves
    private void OnMouseExit() {
        Debug.Log("Mouse exited");
        spr.sprite = normal;
    }

    private void OnMouseDrag() {

        gm.Open(location);
        Debug.Log("Clicked mouse");
        spr.sprite = normal;
    }

   

}
