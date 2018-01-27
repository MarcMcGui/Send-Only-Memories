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
        Debug.Log("Clicked mouse");
        gameObject.SendMessage("open");
        spr.sprite = normal;
    }

    // Use this for initialization
    void Start () 
    {
        Debug.Log("Game started");
        spr = GetComponent<SpriteRenderer>();
        spr.sprite = normal;
	}

}
