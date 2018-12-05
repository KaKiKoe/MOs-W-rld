using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovingUpAndDown : MonoBehaviour {

  LevelManager levelManager;

  public Vector3 startPos;
  public Vector3 newPos;
  public Vector3 tempPos;

  public float speed;

  public SpriteRenderer sr;

  // Use this for initialization
  void Start()
  {
    //Debug.Log(SceneManager.GetActiveScene().name);
    levelManager = FindObjectOfType<LevelManager>();
    startPos = transform.position;

    //Random Speed
    speed = Random.Range(5f, 10f);

    tempPos = startPos;

    sr = gameObject.GetComponent<SpriteRenderer>();
  }

  // Update is called once per frame
  void Update()
  {
    newPos = startPos;
    newPos.y = newPos.y + Mathf.PingPong(Time.time * speed, 6) - 3;
    transform.position = newPos;

    //Bewegung Richtung positive Y-Achse
    if (newPos.x > tempPos.x)
    {
      sr.flipY = true;
    }
    else
    {
      sr.flipY = false;
    }

    tempPos = newPos;
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
