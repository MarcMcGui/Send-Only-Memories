using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LetterClass : MonoBehaviour {
    public GameManager gm;
    public Sprite[] sprites;
    public string[] texts;
    public string[] spriteNames = new string[21] {"ImportantLetter.png", "C1_ace.png", "C1_bd.png", "C1_ace.png", "C1_bd.png", "C1_ace.png", "C2_a.png", "C2_b.png", "C2_c.png", "C2_d.png", "C2_e.png", "C2_f.png", "C3_ace.png", "C3_bd.png", "C3_ace.png", "C3_bd.png", "C3_ace.png", "1_ZackAubrey.png", "1_RubenTerry.png", "1_RubenBridget.png", "1_PrinceAndrew.png"};
    public string[] textNames = new string[21] {"InformativeLetter.txt", "C1_a.txt", "C1_b.txt", "C1_c.txt", "C1_d.txt", "C1_e.txt", "C2_a.txt", "C2_b.txt", "C2_c.txt", "C2_d.txt", "C2_e.txt", "C2_f.txt", "C3_a.txt", "C3_b.txt", "C3_c.txt", "C3_d.txt", "C3_e.txt", "1_ZackAubrey.txt", "1_RubenTerry.txt", "1_RubenBridget.txt", "1_PrinceAndrew.txt"};

    //Amount of time it will take to send the letter (likely between 1 and 14 days)
    public int resourcesNeeded;

    //Whether the player has selected the letter to be sent
    bool selected = false;

    //Whether the player has sent the letter (only changed at the end of the day)
    bool sent = false;

    //Tells whether the letter is from a text file or an img. True if it's an image, false if it's a text file
    bool imgOrTxt;

    //Use this for initialization
    void Start() {
        gm = FindObjectOfType<GameManager>();

        for(int i = 0; i < sprites.Length; i++){
            texts[i] = System.IO.File.ReadAllText(textNames[i]);
            sprites[i] = Resources.Load(spriteNames[i], typeof(Sprite)) as Sprite;

        }

        changeSprite(gm.getIndex());
    }

    // Update is called once per frame
    void Update() {

    }

    //Change sprite when pin is clicked
    void changeSprite(int indexPosition) {
        GetComponent<SpriteRenderer>().sprite = sprites[gm.getIndex()];
        GetComponent<Text>().text = texts[gm.getIndex()];
    }

}
