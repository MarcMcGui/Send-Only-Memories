using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LetterMenu : MonoBehaviour {
    public GameManager gm;
    public PinCorrected clickedPin;
    public int position;
    public LetterClass letter;
    public LetterClass letterbase;
    public Text timeCost;

	// Use this for initialization
	void Start () {
        gm = FindObjectOfType<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {

        if (letter != null)
        {
            if (letter.resourcesNeeded <= (14 - gm.weekTimer))
            {
                timeCost.text = "Letter takes " + letter.resourcesNeeded + " days to deliver";
                timeCost.color = new Color(1, 1, 1);
            }
            else
            {
                timeCost.text = "Letter takes " + letter.resourcesNeeded + " days to deliver";
                timeCost.color = new Color(1, 0, 0);
            }
        }
        else
        {
            timeCost.text = "";
        }

        if ( gm.pinHasClicked )
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
        clickedPin.spr.sprite = clickedPin.normal;
        GameObject.Destroy(letter.gameObject);
        gm.pinHasClicked = false;
    }


    public void Submit()
    {
        if (letter != null)
        {
            Debug.Log("Arfarfanarf");
            if (letter.resourcesNeeded <= (14 - gm.weekTimer)) {
                timeCost.text = "Letter takes " + letter.resourcesNeeded + " days to deliver";
                gm.weekTimer += letter.resourcesNeeded;
                GameObject.Destroy(letter.gameObject);
                gm.pinHasClicked = false;
                clickedPin.hasClicked = true;
                timeCost.color = new Color(1, 1, 1);
                clickedPin.spr.sprite = clickedPin.normal;
            }
            else 
            {
                timeCost.text = "Letter takes " + letter.resourcesNeeded + " days to deliver";
                timeCost.color = new Color(1, 0, 0);
            }
        }
       

    }

    public void CreateLetter(int index)
    {
        letter = Instantiate(letterbase, transform.position, Quaternion.identity);
        letter.index = index;
        letter.resourcesNeeded = position;
        
    }
}
