using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextSpawner : MonoBehaviour {

	// Use this for initialization
	void Start () {

        public class GameManager {
        private static GameManager _instance;

        public static GameManager Instance {
            get {
                if (_instance == null) {
                    _instance = FindObjectOfType<GameManager>();
                }

                return _instance;
            }
        }

        void Awake() {
            DontDestroyOnLoad(gameObject);
        }
    }

}
	
	// Update is called once per frame
	void Update () {
		
	}
}
