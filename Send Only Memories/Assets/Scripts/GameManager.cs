using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    //public variables
    public int weekTimer;
    public int sizeOfLetters;
    public List<int> indicies;
    public bool pinHasClicked;
    public LetterMenu let;

    //private variables
    private int apocalypseCountdown;

	// Use this for initialization
	void Start () {
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
        if ( pinHasClicked)
        {
            let.gameObject.SetActive(true);
        }
        else
        {
            let.gameObject.SetActive(false);
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
