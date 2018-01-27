using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour {

    public int location;

    public Sprite normal;
    public Sprite highlighted;
    public SpriteRenderer spr;

    //Mouse over pin highlights
    //click opens menu

    void onMouseOver() {
        spr.sprite = highlighted;
        if(Input.GetMouseButtonDown(0)) {
            gameObject.SendMessage("open");
            spr.sprite = normal;
        }
    }

    void onMouseExit() {
        spr.sprite = normal;
    }

	// Use this for initialization
	void Start () {
        spr = GetComponent<SpriteRenderer>();
        spr.sprite = normal;
	}

}
