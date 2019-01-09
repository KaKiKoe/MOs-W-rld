using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level_Reset : MonoBehaviour {

  string actualscene;

	// Use this for initialization
	void Start () {
    
  }
	
	// Update is called once per frame
	void Update () {
	}

  public void ReloadScene(){

    PlayerPrefs.DeleteAll(); // Zum (erneuten) Sperren von Leveln!
    Debug.Log("lade scene nach reset button");
    SceneManager.LoadScene("Level_Selection");
  }
}
