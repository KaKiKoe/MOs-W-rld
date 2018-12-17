using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour {

  public Transform bulletSpawn;
  public Transform player;

  public Rigidbody2D bulletPrefab;
  Rigidbody2D clone;

  public float bulletSpeed = 500f; 

	// Use this for initialization
	void Start () {
    bulletSpawn = GameObject.Find ("BulletSpawn").transform; 
	}
	
	// Update is called once per frame
	void Update () {
    if (Input.GetButtonDown ("Fire1"))
    {
      Debug.Log("Feuer frei!");
      Attack();
    }
	}

  void Attack()
  {
    clone = Instantiate (bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
    if (bulletSpawn.position.x > player.position.x)
    {
      clone.AddForce(bulletSpawn.transform.right * bulletSpeed);
    }
    else
    {

      clone.AddForce(bulletSpawn.transform.right * -bulletSpeed);
    }
  }
}
