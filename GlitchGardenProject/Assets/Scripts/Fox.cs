using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Attackers))]
public class Fox : MonoBehaviour {

    private Animator anim;
    private Attackers attackers;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        attackers = GetComponent<Attackers>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collider)
    {
       

        GameObject obj = collider.gameObject;

        if (!obj.GetComponent<Defenders>())
        {
            return;
        }

        if (obj.GetComponent<Stone>())
        {
            anim.SetTrigger ("jumpTrigger");
        } else
        {
            anim.SetBool("isAttacking", true);
            attackers.Attack(obj);
        }
    }
}
