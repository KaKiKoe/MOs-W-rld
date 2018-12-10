using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour 

{
  int starCounter;
  public Text scoreText;
  public Text starText;
  public Text highScoreText;

  StayAlive stayAlive;
  int coinCounter;

  // Use this for initialization
  void Start ()
  {
    stayAlive = GameObject.Find("StayAlive").GetComponent<StayAlive>();

    coinCounter = stayAlive.getCoinCounter();
    starCounter = 0; 

    //lade den aktuellen HighScore
    highScoreText.text = "Highscore: " + PlayerPrefs.GetInt("Highscore").ToString();
    scoreText.text = coinCounter.ToString();
    starText.text = starCounter.ToString();
   
	}
	
	// Update is called once per frame
	void Update () {
		
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
      stayAlive.setCoinCounter(coinCounter);
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
}
