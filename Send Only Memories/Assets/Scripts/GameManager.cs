using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    //public variables
    public int weekTimer;
    public Pin[] pins;
    public int sizeOfLetters;
    public List<int> indicies;
    public bool pinHasClicked;
    public LetterMenu let;
    public GameObject gma;
    public SpriteRenderer sprR;

    //private variables
    private int apocalypseCountdown;

	// Use this for initialization
	void Start () {
        pins = FindObjectsOfType<Pin>();
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

        if ( sprR.color.r < 1)
        {
            for (int i = 0; i < pins.Length; i++)
            {
                pins[i].gameObject.SetActive(false);
            }
            sprR.color = new Color(sprR.color.r + 0.008f, sprR.color.g + 0.008f, sprR.color.b + 0.008f);
        }
        else
        {
            
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
        if ( weekTimer >= 14 )
        {
            apocalypseCountdown += 1;
        }
        
        //transitions to next scene if end of 4 months
		if ( apocalypseCountdown > 8)
        {
            End();
        }
	}

    public void Open(int pos)
    {
        pinHasClicked = true;
        let.position = pos;
    }

    public void End()
    {

    }

    public int getIndex()
    {
        int num = Random.Range(0, indicies.Count);
        indicies.Remove(indicies[num]);
        return indicies[num];
    }
}
