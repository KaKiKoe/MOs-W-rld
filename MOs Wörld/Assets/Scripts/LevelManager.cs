using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour {

  public GameObject currentCheckpoint;

  public GameObject Player;

  
  public int health;
  public Text healthText;

  public Text TimerText;
  public float roundTimer;

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
    
    roundTimer = roundTimer - Time.deltaTime;
    TimerText.text = roundTimer.ToString();

    if (roundTimer <= 0f)
    {
      SceneManager.LoadScene("End_fail");
    }
   
  }
  public void RespawnPlayer()
  {
    //Leben abziehen
    health = health - 1;
    //Lebensanzeige aktualisieren
    healthText.text = health.ToString();
    //Überprüfen ob Spieler noch Leben hat
    if (health > 0)
    {
      //falls ja -> Respawn
      Player.transform.position = currentCheckpoint.transform.position;
    }
    else
    {
      //falls nein -> Spielende
      //Time.timeScale = 0.0f;
      SceneManager.LoadScene("End_fail");
    }
  }
}
