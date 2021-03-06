﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestruction : MonoBehaviour {

  public uint health;

  public Sprite damage1;
  public Sprite damage2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

  private void OnCollisionEnter2D(Collision2D collision)
  {
    if(collision.gameObject.tag.Equals("Kill"))
    {
      Destroy(gameObject);
    }
    if(collision.gameObject.tag.Equals("Bullet"))
    {
      Destroy(collision.gameObject);
  

      if(health < 1)
      {
        Destroy(gameObject);

      }
      health--;

      //Second Skin after Hit
      if (health == 1)
      {
        this.GetComponent<SpriteRenderer>().sprite = damage1;
      }
    }
  }
}
