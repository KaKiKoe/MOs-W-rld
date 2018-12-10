using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Checkpoint : MonoBehaviour
{

  public LevelManager levelManager;

 
  // Use this for initialization
  void Start()
  {
    levelManager = FindObjectOfType<LevelManager>();
  }

  // Update is called once per frame
  void Update()
  {

  }
  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.tag == "Player")
    {
      Debug.Log("Checkpoint erreicht");
      levelManager.currentCheckpoint = gameObject;

    }
  }


}
