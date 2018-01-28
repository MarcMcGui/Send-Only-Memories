using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterMenu : MonoBehaviour {
    public GameManager gm;
    public int position; 

	// Use this for initialization
	void Start () {
        gm = FindObjectOfType<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
		if( gm.pinHasClicked )
        {
            Debug.Log("what");
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
	}

    public void Quit()
    {
        gm.pinHasClicked = false;
    }


    public void Submit()
    {
        
    }
}
