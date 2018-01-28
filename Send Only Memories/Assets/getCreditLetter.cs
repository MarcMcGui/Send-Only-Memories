using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getCreditLetter : MonoBehaviour {

    public GameManager gm;
    public int index;

    // Use this for initialization
    void Start () {
        index = -1;
}
	
	// Update is called once per frame
	void Update () {
        if(index >= 0) {
            GetComponent<SpriteRenderer>().sprite = sprites[gm.GetIndex(index)];
        }
    }
}
