using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Reset : MonoBehaviour {

	// Use this for initialization
	void Start () {
    PlayerPrefs.DeleteAll(); // Zum (erneuten) Sperren von Leveln!
  }
	
	// Update is called once per frame
	void Update () {
		
	}
}
