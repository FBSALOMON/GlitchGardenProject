﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public float autoLoadNextLevelAfter;

    void Start()
    {
        if (autoLoadNextLevelAfter <= 0) {
            Debug.Log("Level auto load disabled, use a positive number in seconds");
        } else
        {
            Invoke("LoadNextLevel", autoLoadNextLevelAfter);
        }
       
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
