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
    breathBarSlider.value = 1;
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
        breathBarSlider.value -= .003f;
      }
      else
      {
        breathBarSlider.value += .006f;
      }
    }
    else 
    {
      SceneManager.LoadScene("End_fail");
    }
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.tag == "Bubble")
    {
      //Grafik deaktivieren
      collision.gameObject.GetComponent<Renderer>().enabled = false;

      // Sound des Bubbles abspielen
      //AudioSource audio = collision.gameObject.GetComponent<AudioSource>();
      //audio.Play();

      //Bubble zerstören
      Destroy(collision.gameObject); //, audio.clip.length);

      //Atemanzeige auffüllen
      breathBarSlider.value += .500f;
    }
  }
}