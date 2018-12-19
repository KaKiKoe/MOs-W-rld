using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextLevel : MonoBehaviour
{
  public string sceneToLoad;


  private void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "Player")
    {
      // SceneManager.LoadScene(SceneManager.GetSceneAt(0).buildIndex +1);

      LoadLevel();
    }
  }

  void LoadLevel()
  {
    // nächste Szene laden
    SceneManager.LoadScene(sceneToLoad);


    // Fortschritt speichern
    if (PlayerPrefs.GetInt(sceneToLoad.ToString()) == 0)
    {
      //Level jetzt freischalten
      PlayerPrefs.SetInt(sceneToLoad.ToString(), 1);
    }
  }
}

  

