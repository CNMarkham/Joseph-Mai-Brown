using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour
{
    Animator animator;
    Jump jump;
    Movement movement;

    void Start()
    {
        animator = GetComponent<Animator>();
        jump = GetComponent<Jump>();
        movement = GetComponent<Movement>();
    }

    void Update()
    {
        animator.SetBool("grounded", jump.isGrounded);
        animator.SetFloat("speed", movement.speed);
    }
}
