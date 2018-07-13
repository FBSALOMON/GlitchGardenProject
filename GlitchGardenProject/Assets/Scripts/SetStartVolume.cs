using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetStartVolume : MonoBehaviour {

    private MusicManager musicManager;

	// Use this for initialization
	void Start () {
        if (musicManager)
        {
            musicManager = GameObject.FindObjectOfType<MusicManager>();
            musicManager.SetVolume(PlayerPrefsManager.GetMasterVolume());
        } else
        {
            Debug.Log("Music not found, can't set volume");
        }
        
      
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
