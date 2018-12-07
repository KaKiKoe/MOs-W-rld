using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreathDisplay : MonoBehaviour {

  private Rigidbody2D rb;
  public ImagePosition Breath;
  float posX;

  void PositionMoBreath()
  {
    if (rb.position.y < -6)
    {
      Breath = Breath - 50;
    }
  }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () 
  {
    PositionMoBreath();
  }
}
