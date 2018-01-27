using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour {

    //should determine what menu opens
    public int location;

    public Sprite normal;
    public Sprite highlighted;
    public SpriteRenderer spr;

    //highlights sprite when mouse over pin,
    //opens menu when clicked
    void onMouseOver() {
        spr.sprite = highlighted;
        if(Input.GetMouseButtonDown(0)) {
            gameObject.SendMessage("open");
            spr.sprite = normal;
        }
    }

    //reverts sprite backt to normal when
    //mouse leaves pin
    void onMouseExit() {
        spr.sprite = normal;
    }

	// Use this for initialization
	void Start () {
        spr = GetComponent<SpriteRenderer>();
        spr.sprite = normal;
	}

}
