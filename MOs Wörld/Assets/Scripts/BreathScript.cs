using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BreathScript : MonoBehaviour
{

  public Slider breathBarSlider;  
  private Rigidbody2D rb;

  void Start()
  {
    rb = GetComponent<Rigidbody2D>();
    breathBarSlider.value = 100;
  }

  // Update is called once per frame
  void Update()
  {
    PositionMo();
  }

  void PositionMo()
  {
    if (breathBarSlider.value >= .001f)
    {
      if (rb.position.y < -6)
      {
        breathBarSlider.value -= .005f;
      }
      else
      {
        breathBarSlider.value += .005f;
      }
    }
    else 
    {
      SceneManager.LoadScene("End_fail");
    }
  }
}