using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour {
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        Attackers attacker = collider.gameObject.GetComponent<Attackers>();

        if (attacker)
        {
            animator.SetTrigger("underAttack trigger");
        }
    }
}
