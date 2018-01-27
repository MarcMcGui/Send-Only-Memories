using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Quit()
    {
        gameObject.SetActive(false);
    }

    public void Open()
    {
        gameObject.SetActive(true);
    }

    public void Submit()
    {
        
    }
}
