using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour {


  public LevelManager levelManager;
  // Use this for initialization
  void Start()
  {
    //Debug.Log(SceneManager.GetActiveScene().name);
    levelManager = FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
   
	}
  private void OnCollisionEnter2D(Collision2D collision)
  {
    if (collision.gameObject.tag == "Player")
    {
      //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
      Debug.Log("ein Leben verloren");
      levelManager.RespawnPlayer();
      Debug.Log("du wirst an den currentCheckpoint versetzt");
    }

      //Gegner zerstören
    if (collision.gameObject.tag == "Bullet")
    {
      Destroy (collision.gameObject, 0.01f);
      Destroy (gameObject, 0.01f);
    }
  }
}
