using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerCountdown : MonoBehaviour {

  public int TimeLeft = 100;
  public Text TimerText;

	// Use this for initialization
	void Start () 
  {
    StartCoroutine("LoseTime");
	}
	
	// Update is called once per frame
	void Update () 
  {
    TimerText.text = ("Restzeit = " + TimeLeft);

    if (TimeLeft <= 0)
    {
      StopCoroutine("LoseTime");
      TimerText.text = "Zeit abgelaufen!";
    }
	}

  IEnumerator LoseTime()
  {
    while (true)
    {
      yield return new WaitForSeconds(1);
      TimeLeft--;
    }
  }
}
