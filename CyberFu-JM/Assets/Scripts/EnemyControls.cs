using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControls : MonoBehaviour
{
    public float speed = 2f; // set speed of the enemy
    public float attackingDistance = 0.6f; //the set attacking distance for the enemy

    private Animator animatorEnemy; //animator component controls the animation for the enemy
    private Rigidbody rigidbodyEnemy; //the rigidbody component controlls the physics for the enemy
    private Transform target; //finds the target of a object with the var

    [SerializeField]
    private bool isFollowingTarget; // checks if the enemy is following the target or not

    private float currentAttackingTime = 0f; // current value of the time is for the attack
    private float maxAttackingTime = 2f; // set the maximum time of attacking
    // Start is called before the first frame update
    void Start()
    {
        animatorEnemy = GetComponent<Animator>();//gets the component for the animator
        rigidbodyEnemy = GetComponent<Rigidbody>();//getting the component for the rigidbody
        target = GameObject.FindGameObjectWithTag("Player").transform;//finds a target with the tag of player
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target.position);// makes the enemy look at the target at its position
        isFollowingTarget = Vector3.Distance(transform.position, target.position) >= attackingDistance; // sets the following target distance higher than attacking distance

        if(isFollowingTarget)
        {
            rigidbodyEnemy.velocity = transform.forward * speed;
        }
        else
        {
            Attack();
        }
        animatorEnemy.SetBool("Walk", isFollowingTarget);
    }

    void Attack()
    {
        
        rigidbodyEnemy.velocity = Vector3.zero; //keeps the enemy from moving within its place

        currentAttackingTime += Time.deltaTime;

        if(currentAttackingTime > maxAttackingTime)// if current attack time is greater than max attack time
        {
            currentAttackingTime = 0f;
            int rand = Random.Range(1, 6);
            
            animatorEnemy.SetTrigger("Attack" + rand);
            Debug.Log(rand);
        }

    }

}
