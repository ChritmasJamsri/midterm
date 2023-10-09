using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
     private int healthPoint = 2;
     private  Animator  animator;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("HIT");
    }

    void Start()
    {
        animator  = GetComponent<Animator>();
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            Attack();

        }

        else if (Input.GetKey(KeyCode.Z))
        {
            Dead();
        }

        
    }

    private void Attack()
    {
        animator.SetTrigger("Attack");


    }

    private void Dead()
    {
        animator.SetBool("Death",true);


    }
}



