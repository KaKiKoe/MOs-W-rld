using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour 

{
  private int coinCounter;
  public int starCounter;
  public Text scoreText;
  public Text starText;
  public Text highScoreText;

  public PlayerControll playercontroll;
  private Rigidbody2D rb;

  // Use this for initialization
  void Start ()
  {
    playercontroll = FindObjectOfType<PlayerControll>();
    rb = GetComponent<Rigidbody2D>();

    coinCounter = 0;
    starCounter = 0; 

    //lade den aktuellen HighScore
    highScoreText.text = "Highscore: " + PlayerPrefs.GetInt("Highscore").ToString();
    scoreText.text = coinCounter.ToString();
    starText.text = starCounter.ToString();
   
	}
	
	// Update is called once per frame
	void Update () {
    lvlfreigeschaltet();
	}
  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.tag == "Coin")
    {
      //Grafik deaktivieren
      collision.gameObject.GetComponent<Renderer>(). enabled = false;

      //sound der Münze abspielen
      AudioSource audio = collision.gameObject.GetComponent<AudioSource>();
      audio.Play();
       
      //Münze zerstören
      Destroy(collision.gameObject, audio.clip.length);

      coinCounter++;
      scoreText.text = coinCounter.ToString();

      if (coinCounter > PlayerPrefs.GetInt("Highscore"))
      {
        //Überschreibe den Highscore
        PlayerPrefs.SetInt("Highscore", coinCounter);
        highScoreText.text = "Highscore: " + PlayerPrefs.GetInt("Highscore").ToString();
      }
    }

    if (collision.tag == "Star")
    {
    
      //Grafik deaktivieren
      collision.gameObject.GetComponent<Renderer>(). enabled = false;

      // Sound des Sterns abspielen
      AudioSource audio = collision.gameObject.GetComponent<AudioSource>();
      audio.Play();

      //Stern zerstören 
      Destroy(collision.gameObject, audio.clip.length);

      starCounter++;
      starText.text = starCounter.ToString();
    }
  }

  void lvlfreigeschaltet (){
    // Beim Sammeln von 2 von 3 Sternen nächste Szene freischalten


    if (starCounter >= 2 && rb.position.x > 440)
    {
      Debug.Log("Das nächste Level wurde freigeschalten");

      // aktuelle Szene abfragen
      string scenename = SceneManager.GetActiveScene().name;


      if (scenename == "Level_1")
      {
        PlayerPrefs.SetInt("Level_2", 1);
        Debug.Log("Level 2 Wurde freigeschalten");
      }

      else if (scenename == "Level_2")
      {
        Debug.Log("Lvl 3 wurde freigeschalten");
        PlayerPrefs.SetInt("Intro_Schießen", 1);
      }
    }
    else
    {
      Debug.Log("nicht genug Sterne oder Ziel noch nicht erreicht");
    }
  }
}