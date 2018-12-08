using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayAlive : MonoBehaviour {

  int coinCounter;


	// Use this for initialization
	void Start () {
    DontDestroyOnLoad(gameObject);
    coinCounter = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

  public void setCoinCounter(int coins)
  {
    coinCounter = coins;
  }

  public int getCoinCounter()
  {
    return coinCounter;
  }
}
