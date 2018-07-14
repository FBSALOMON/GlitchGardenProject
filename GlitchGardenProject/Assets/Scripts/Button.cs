﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

    public GameObject defenderPrefab;

    private Button[] buttonArray;
    private static GameObject selectedDefender;


    void Start()
    {
        buttonArray = GameObject.FindObjectsOfType<Button>();
    }

    private void OnMouseDown()
    {
        print(name + " pressed");

        foreach (Button thisButton in buttonArray)
        {
            thisButton.GetComponent<SpriteRenderer>().color = Color.black;
        }

        GetComponent<SpriteRenderer>().color = Color.white;
        selectedDefender = defenderPrefab;
    }
}