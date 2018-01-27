using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour {

    public int location;

    //Mouse over pin highlights
    //click opens menu

    void onMouseDown() {
        gameObject.SendMessage("open");
    }

    void onMouseOver() {
        
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
