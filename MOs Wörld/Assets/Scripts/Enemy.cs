using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour {


  LevelManager levelManager;
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

      levelManager.RespawnPlayer();
    }
  }
}
