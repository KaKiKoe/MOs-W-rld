using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartOnClick : MonoBehaviour {

  public string sceneToLoad;


  void Start ()
  {
    PlayerPrefs.DeleteAll(); // Zum (wieder) Sperren von Leveln!


    // Level_1 und Buttons etc. auf aktiv schalten!
    PlayerPrefs.SetInt("Level_1", 1);
    PlayerPrefs.SetInt("Main_Menu", 1);
    PlayerPrefs.SetInt("Level_Selection", 1);
    PlayerPrefs.SetInt("End_fail", 1);
    PlayerPrefs.SetInt("End_success", 1);
    PlayerPrefs.SetInt("Shop", 1);
    PlayerPrefs.SetInt("Intro_Steuerung", 1);
    PlayerPrefs.SetInt("Level_3", 1);


    if (PlayerPrefs.GetInt(sceneToLoad.ToString()) == 1)
    {
      // Level aktiv -> Button aktivieren
      this.GetComponent<Button>().interactable = true;
    }
    else
    {
      // Level inaktiv -> Button deaktivieren
      this.GetComponent<Button>().interactable = false;
    }
  }
	public void StartLevel()
  {
    SceneManager.LoadScene(sceneToLoad);
  }
}
