using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextLevel : MonoBehaviour
{
  private void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "Player")
    {
      SceneManager.LoadScene(SceneManager.GetSceneAt(0).buildIndex +1);
    }
  }
}

  

