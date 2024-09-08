using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Goal : MonoBehaviour
{
    public Transform goal;
    private Animator animator;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (agent.hasPath)
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }
    }
}


