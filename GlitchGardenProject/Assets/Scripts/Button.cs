using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour {

    public GameObject defenderPrefab;

    private Button[] buttonArray;
    public static GameObject selectedDefender;
    private Text myText;


    void Start()
    {
        buttonArray = GameObject.FindObjectsOfType<Button>();
        myText = GetComponentInChildren<Text>();
        if(!myText)
        {
            Debug.Log("Need a cost componet");
        } else
        {
            myText.text = defenderPrefab.GetComponent<Defenders>().starCost.ToString();
        }
        
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
