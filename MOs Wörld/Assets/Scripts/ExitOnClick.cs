﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitOnClick : MonoBehaviour {

	public void Quit()
  {
    Debug.Log("Button Geklickt und SPiel verlassen");

    if (UnityEditor.EditorApplication.isPlaying == true)
    {
      UnityEditor.EditorApplication.isPlaying = false;
    }
    else
    {
      Application.Quit();
    }
  }
}
