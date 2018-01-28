﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    //public variables
    public int weekTimer;
    public Text warning;
    public Text cycle;
    public float breakTimer;
    public PinCorrected[] pins;
    public int sizeOfLetters;
    public List<int> indicies;
    public bool pinHasClicked;
    public LetterMenu let;
    public GameObject gma;
    public SpriteRenderer sprR;
    public int apocalypseCountdown;

    //private variables


    // Use this for initialization
    void Start () {
        breakTimer = 0;
        pins = FindObjectsOfType<PinCorrected>();
        sprR = gma.GetComponent<SpriteRenderer>();
        sprR.color = new Color(0, 0, 0);
        indicies = new List<int>();
        for ( int i = 0; i < sizeOfLetters; i++)
        {
            indicies.Add(i);
        }
        pinHasClicked = false;
        apocalypseCountdown = 0;

    }
	
	// Update is called once per frame
	void Update () {
        if (breakTimer <= 0)
        {
            cycle.text = "";
            warning.text = "";
            if (sprR.color.r < 1)
            {
                for (int i = 0; i < pins.Length; i++)
                {
                    pins[i].gameObject.SetActive(false);
                }
                sprR.color = new Color(sprR.color.r + 0.005f, sprR.color.g + 0.005f, sprR.color.b + 0.005f);
            }
            else
            {
                cycle.text = "Days Before Next Mail cycle " + (14 - weekTimer) + "";

                if (pinHasClicked)
                {
                    for (int i = 0; i < pins.Length; i++)
                    {
                        pins[i].gameObject.SetActive(false);
                    }
                    let.gameObject.SetActive(true);
                }
                else
                {
                    for (int i = 0; i < pins.Length; i++)
                    {
                        pins[i].gameObject.SetActive(true);
                    }
                    let.gameObject.SetActive(false);
                }
            }



            //Increases the time to end if all weeks have been used. 
            if (weekTimer >= 14)
            {
                breakTimer = 5;
                apocalypseCountdown += 1;
                weekTimer = 0;
            }

            //transitions to next scene if end of 4 months
            if (apocalypseCountdown > 2)
            {
                End();
            }
        }
        else
        {
            for (int i = 0; i < pins.Length; i++)
            {
                pins[i].gameObject.SetActive(false);
            }
            if (sprR.color.r > 0)
            {
                sprR.color = new Color(sprR.color.r - 0.005f, sprR.color.g - 0.005f, sprR.color.b - 0.005f);
            }
            warning.text = ((3 - apocalypseCountdown) * 2) + " Weeks Remaining";
            breakTimer -= Time.deltaTime;
            
        }

        
	}

    public void Open(int pos)
    {
        pinHasClicked = true;
        
        let.position = pos;
        let.CreateLetter();
    }

    public void End()
    {

    }

    public int getIndex()
    {
        int num = Random.Range(0, indicies.Count);
        int temp = indicies[num];
        indicies.Remove(indicies[num]);
        return temp;
    }
}
