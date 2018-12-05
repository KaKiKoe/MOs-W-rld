using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelManager : MonoBehaviour {

  //public GameObject currentCheckpoint;

  
  public GameObject Player;
 

  
  public int health;
  public Text healthText;

  void Start()
  {
    healthText.text = health.ToString();
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Escape))
    {
      //Spiel beenden
      Debug.Log("Spiel wird beendet");
      Application.Quit();
    }
  }


  public void RespawnPlayer()
  {
  
  //Player.transform.position = currentCheckpoint.transform.position;

  //Leben abziehen
  health = health - 1;
    //Lebensanzeige aktualisieren
    healthText.text = health.ToString();
    //Überprüfen ob Spieler noch Leben hat
    if(health > 0)
    {
      //falls ja -> Respawn
      Player.transform.position = Player.transform.position;
    }
    else
    {
      Time.timeScale = 0.0f;
    }

    //falls nein -> Spielende
  }	
}
