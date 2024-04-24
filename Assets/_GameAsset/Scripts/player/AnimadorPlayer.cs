using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimadorPlayer : MonoBehaviour
{
    float horizontal;
    Animator animator;
    private Rigidbody2D playerRB2D;
    private Ki ki;
    void Start()
    {
        animator = GetComponent<Animator>();
        playerRB2D = GetComponent<Rigidbody2D>();
        ki=GetComponent<Ki>();
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        animator.SetFloat("Horizontal", Math.Abs(horizontal));
        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetBool("ataque", true);
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            animator.SetBool("ataque", false);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            animator.SetBool("patada", true);

        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            animator.SetBool("patada", false);
        }
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            animator.SetBool("carga", true);

        }
        if (Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow))
        {
            animator.SetBool("carga", false);
        }
         if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetBool("ki", true);
            ki.Disparo();

        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            animator.SetBool("ki", false);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        animator.SetBool("enSuelo", true);
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        animator.SetBool("enSuelo", true);
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        animator.SetBool("enSuelo", false);
    }
}
