using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class freeall_Level : MonoBehaviour
{

  string actualscene;

  // Use this for initialization
  void Start()
  {
    
  }

  // Update is called once per frame
  void Update()
  {
  }
  
  public void ReloadScene()
  {

    PlayerPrefs.SetInt("Intro_Schießen", 1);
    PlayerPrefs.SetInt("Level_2", 1);

    Debug.Log("lade scene nach freeall button");
    SceneManager.LoadScene("Level_Selection");
  }
}

