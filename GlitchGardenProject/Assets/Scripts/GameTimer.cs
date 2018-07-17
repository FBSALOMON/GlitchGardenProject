using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour {

    private Slider mainSlider;
    LevelManager levelManager;
    public int TimeToWin;
    private AudioSource audioSource;
    private GameObject winLabel;
    private bool isPlaying = false;

    // Use this for initialization
    void Start ()
    {
        mainSlider = GetComponent<Slider>();
        levelManager = GameObject.FindObjectOfType<LevelManager>();
        audioSource = GetComponent<AudioSource>();
        FindYouWin();
        winLabel.SetActive(false);
    }

    private void FindYouWin()
    {
        winLabel = GameObject.Find("You win");
        if (!winLabel)
        {
            Debug.LogWarning("Please create You Win object");
        }
    }

    // Update is called once per frame
    void Update () {
        mainSlider.value += Time.deltaTime/TimeToWin;
        TimeEnd();
    }

    void TimeEnd()
    {
        if(mainSlider.value >= 1 && !isPlaying)
        {
            DestroyAllTaggedObjects();
            HandleWinCondition();
        }
    }

    private void HandleWinCondition()
    {
        audioSource.Play();
        isPlaying = true;
        winLabel.SetActive(true);
        Invoke("LoadNextLevel", audioSource.clip.length);
    }

    void DestroyAllTaggedObjects()
    {
        GameObject[] taggedObjectArray = GameObject.FindGameObjectsWithTag("DestroyOnWin");
        foreach(GameObject gameObject in taggedObjectArray)
        {
            DestroyObject(gameObject);
        }
    }

    void LoadNextLevel()
    {
        levelManager.LoadLevel("03a Win");
    }
}