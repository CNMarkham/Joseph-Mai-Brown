using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPY : MonoBehaviour
{
    Animator Animator;

    void Start()
    {
        Animator = GetComponent<Animator>();
    }
    void Update()
    {
        if(Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0){
            Animator.SetBool("isRunning", true);
        } else{
            Animator.SetBool("isRunning", false);
        }
    }
}
