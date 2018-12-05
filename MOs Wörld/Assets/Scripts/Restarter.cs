using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{

  public class Restarter : MonoBehaviour
  {
    public LevelManager levelManager;

    void Start()
    {
      levelManager = FindObjectOfType<LevelManager>();
    }
    private void Update()
    {
      
    }
    void OnCollisionEnter2D(Collision2D other)
    {
      if (other.gameObject.tag == "Player")
      {
        //SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
        levelManager.RespawnPlayer();
      }
    }
  }
}
