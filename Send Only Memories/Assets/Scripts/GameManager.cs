using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    //public variables
    public int weekTimer;

    //private variables
    private int apocalypseCountdown;

	// Use this for initialization
	void Start () {
        apocalypseCountdown = 0;

    }
	
	// Update is called once per frame
	void Update () {

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

    public void End()
    {

    }
}
