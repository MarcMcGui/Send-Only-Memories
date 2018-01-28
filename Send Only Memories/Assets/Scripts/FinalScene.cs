using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalScene : MonoBehaviour {
    public string[] wrongIndices;
    public int[] indices;
    public LetterClass anchor;

	// Use this for initialization
	void Start () {
        System.IO.StreamReader data = new System.IO.StreamReader(@"indices.txt");
        string dataToLoad = data.ReadLine();
        wrongIndices = dataToLoad.Split(',');
        data.Close();

        indices = new int[wrongIndices.Length - 1];

        for (int i = 0; i < indices.Length; i++)
        {
            indices[i] = int.Parse(wrongIndices[i]);

            var item = Instantiate(anchor, transform);
            item.gameObject.GetComponent<SpriteRenderer>().sprite = item.sprites[indices[i]];
            item.transform.position = new Vector3(item.transform.position.x, item.transform.position.y + (i * 2), 0);
        }
        

             
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
