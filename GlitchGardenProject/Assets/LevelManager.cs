﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public float autoLoadNextLevelAfter;

    public void Start()
    {
        Invoke ("LoadNextLevel", autoLoadNextLevelAfter);
    }

    public void LoadLevel(string name) {
		Debug.Log("Level load requested for: " + name);
        SceneManager.LoadScene(name);	
	}
	
	public void QuitRequest() {
		Debug.Log("Quit request");
		Application.Quit();
	}
	
	public void LoadNextLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
